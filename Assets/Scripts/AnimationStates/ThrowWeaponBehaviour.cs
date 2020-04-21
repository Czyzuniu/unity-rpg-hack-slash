using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowWeaponBehaviour : StateMachineBehaviour
{
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        if (stateInfo.normalizedTime > 0.75) {
            Combat combat = animator.gameObject.GetComponent<Combat>();
            if (combat) {
                combat.ThrowWeapon();
            }
        }
    }
}
