using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    void Start() {
        Physics.IgnoreLayerCollision(8,8);
    }

    void OnTriggerEnter(Collider collider) {
        GameObject hitObject = collider.gameObject;
        StatsController stats = hitObject.GetComponent<StatsController>();
        Animator animator = hitObject.GetComponent<Animator>();
        if (animator) {
            if (stats) {
                animator.SetTrigger("Hit");
                animator.SetInteger("HitDirection", -1);
                stats.MinusHealth(30);
                if (stats.health <= 0) {
                    stats.Die();
                }
            }
        }
    }
}
