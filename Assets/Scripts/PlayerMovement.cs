using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float GRAVITY = -9.81f;
    public float SPEED = 4.0f;
    public float JUMP_FORCE = 3.0f;
    public float ROTATESPEED = 2.0f;
    public float SPEED_BOOST = 3.0f;
    public float SPEED_CAP = 25.0f;
    private float baseSpeed;

    public bool canRun = true;

    private CharacterController controller;
    private Vector3 velocity = Vector3.zero;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        baseSpeed = SPEED;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 rotation = new Vector3(0, ROTATESPEED * horizontal, 0);
        Vector3 move = new Vector3(0, velocity.y, vertical);
        move = this.transform.TransformDirection(move);

        controller.Move(move * Time.deltaTime * SPEED);
        this.transform.Rotate(rotation);


        if (!controller.isGrounded) {
            velocity.y += GRAVITY * Time.deltaTime;
        } else {
            if (Input.GetKeyDown(KeyCode.Space)) {
                velocity.y = 0;
                velocity.y += JUMP_FORCE;
                animator.SetTrigger("Jump");
            }
            if (Input.GetKey(KeyCode.LeftShift) && vertical > 0 && canRun) {
                animator.SetBool("isRunToggled", true);
                if (SPEED < SPEED_CAP) {
                    SPEED += SPEED_BOOST;
                } 
            } else {
                SPEED = baseSpeed;
                animator.SetBool("isRunToggled", false);
            }
        }
        animator.SetFloat("Forward", vertical);
    }
}
