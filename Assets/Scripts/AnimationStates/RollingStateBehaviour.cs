using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingStateBehaviour : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        PlayerMovement movement = animator.GetComponent<PlayerMovement>();
        if (movement) {
            movement.StartRoll();
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        PlayerMovement movement = animator.GetComponent<PlayerMovement>();
        if (movement) {
            movement.StopRoll();
        }
    }
}
