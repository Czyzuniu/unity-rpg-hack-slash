using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerInputActions inputAction;
    public float GRAVITY = -9.81f;
    public float walkSpeed = 2f;
    public float runSpeed = 5f;
    public float inCombatSpeed = 3.0f;
    public float inCombatRunSpeed = 5.0f;
    public float jumpForce = 3.0f;

    public bool canRun = true;
    public float rollDistance = 15;

    private bool isRunning;
    private bool inRoll;
    private int rollDirection = 1;
    private CharacterController controller;
    private Vector3 velocity = Vector3.zero;
    private Combat combatController;
    public bool isStrafing;
    public bool isMoving;
    public float currentSpeed;
    public Camera mainCamera;

    Vector2 movementInput;

    Animator animator;
    // Start is called before the first frame update

    void Awake() {
        inputAction = new PlayerInputActions();
        inputAction.PlayerControls.Move.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
        inputAction.PlayerControls.Jump.performed += ctx => Jump();
        inputAction.PlayerControls.Run.performed += ctx => ToggleRun(true);
        inputAction.PlayerControls.Run.canceled += ctx => ToggleRun(false);
        inputAction.PlayerControls.Roll.performed += ctx => Roll();
    }

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        combatController = GetComponent<Combat>();
    }

    void Jump() {
        if (!combatController.inCombatStance && controller.isGrounded) {
            velocity.y = 0;
            velocity.y += jumpForce;
            animator.SetTrigger("Jump");
        }
    }

    void Roll() {
        if (!inRoll) {
            rollDirection = GetRollDirection();
            animator.SetInteger("RollDirection", rollDirection);
            animator.SetTrigger("Roll");
        }
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = movementInput.y;
        float horizontal = movementInput.x;

        isStrafing = Mathf.Abs(horizontal) > 0;
        isMoving = Mathf.Abs(vertical) > 0 || isStrafing;
        velocity = new Vector3(horizontal, velocity.y, vertical);

        if (!controller.isGrounded) {
            velocity.y += GRAVITY * Time.deltaTime;
        }

        velocity = this.transform.TransformDirection(velocity);
        animator.SetBool("IsMoving", isMoving);
        animator.SetFloat("Horizontal", horizontal);
        if (isMoving) { 
            transform.right = mainCamera.transform.right;
        }
        currentSpeed = Mathf.Lerp(currentSpeed, GetDesiredSpeed(), 2f * Time.deltaTime);
        animator.SetFloat("Forward", currentSpeed);

        controller.Move(velocity * Time.deltaTime * (!controller.isGrounded ? walkSpeed : currentSpeed));
    }


    private void ToggleRun(bool isRunning) {
        this.isRunning = isRunning;
    }

    private float GetDesiredSpeed() {
        bool inCombat = combatController.inCombatStance;
        if (isMoving) {
            if (inCombat && isRunning) {
                return inCombatRunSpeed;
            }
            else if (inCombat) {
                return inCombatSpeed;
            }
            else if (isRunning) {
                return runSpeed;
            }

            return walkSpeed;
        }
        return 0f;
    }

    public void StartRoll() {
        inRoll = true;
    }

    public void StopRoll() {
        inRoll = false;
    }

    private void RollUpdate() {
        if (inRoll) {
            if (rollDirection == 1) {
                velocity.z = Mathf.Lerp(0, rollDistance, 5 * Time.deltaTime);
            } else if (rollDirection == -1) {
                velocity.z = Mathf.Lerp(0, -rollDistance, 5 * Time.deltaTime);
            }
            else if (rollDirection == -2) {
                velocity.x = Mathf.Lerp(0, -rollDistance, 5 * Time.deltaTime);
            } else if (rollDirection == 2) {
                velocity.x = Mathf.Lerp(0, rollDistance, 5 * Time.deltaTime);
            }
        } 
    }

    private int GetRollDirection() {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        int direction = 1;

        if (vertical > 0) {
            direction = 1;
        } else if (vertical < 0) {
            direction = -1;
        } else if (horizontal > 0) {
            direction = 2;
        } else if (horizontal < 0) {
            direction = -2;
        }

        return direction;
    }

    private void OnEnable() {
        inputAction.Enable();
    }

    private void OnDisable() {
        inputAction.Disable();
    }
}
