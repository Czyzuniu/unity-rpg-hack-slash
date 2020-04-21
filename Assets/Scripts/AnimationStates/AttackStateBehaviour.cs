using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackStateBehaviour : StateMachineBehaviour
{
    // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        ToggleAttack(false, animator);
    }

    // OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        float normalizedTime = stateInfo.normalizedTime;
        if (normalizedTime > 0.5) {
            ToggleCollider(false, animator);
        }

        if (normalizedTime > 0.8) {
            ToggleAttack(true, animator);
        }
    }

    private void ToggleCollider(bool toggle, Animator animator) {
        Combat combat = animator.GetComponent<Combat>();
        if (combat) {
            combat.ToggleWeaponColliders(toggle);
        }
    }

    private void ToggleAttack(bool toggle, Animator animator) {
        Combat combat = animator.GetComponent<Combat>();
        if (combat) {
            combat.canAttack = toggle;
        }
    }

}
