using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float GRAVITY = -9.81f;
    public float SPEED = 4.0f;
    public float COMBAT_SPEED = 3.0f;
    public float JUMP_FORCE = 3.0f;
    public float ROTATESPEED = 2.0f;
    private float baseSpeed;

    public bool canRun = true;

    private CharacterController controller;
    private Vector3 velocity = Vector3.zero;
    private Combat combatController;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        baseSpeed = SPEED;
        combatController = GetComponent<Combat>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 rotation = new Vector3(0, ROTATESPEED * horizontal, 0);

        velocity.z = vertical;

        velocity = new Vector3(0, velocity.y, velocity.z);

        if (!controller.isGrounded) {
            velocity.y += GRAVITY * Time.deltaTime;
        } else {
            if (Input.GetKeyDown(KeyCode.Space)) {
                velocity.y = 0;
                velocity.y += JUMP_FORCE;
                animator.SetTrigger("Jump");
            }
        }

        if (Input.GetKeyDown(KeyCode.X)) {
            animator.SetTrigger("RollForward");
        }

        animator.SetFloat("Forward", vertical);

        velocity = this.transform.TransformDirection(velocity);

        controller.Move(velocity * Time.deltaTime * (combatController.inCombatStance ? COMBAT_SPEED : SPEED));
        this.transform.Rotate(rotation);
    }


}
