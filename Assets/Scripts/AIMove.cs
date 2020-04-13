using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    private Animator animator;

    void Start() {
        animator = GetComponent<Animator>();
    }

    void SetKinematic(bool newValue) {
        Rigidbody[] bodies = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in bodies) {
            if (newValue) {
                //Freeze(rb);
            }
            else {
                //UnFreeze(rb);
            }
        }
    }

    void Die() {
        SetKinematic(false);
        GetComponent<Animator>().enabled = false;
    }

    void Freeze(Rigidbody rb) {
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }

    void UnFreeze(Rigidbody rb) {
        rb.constraints = RigidbodyConstraints.None;
    }

    void OnCollisionEnter(Collision c) {
        if (c.collider.gameObject.tag == "axe") {
            Rigidbody rb = GetComponent<Rigidbody>();
            float magnitude = 50;
            // calculate force vector
            Vector3 force = transform.position - c.transform.position;
            // normalize force vector to get direction only and trim magnitude
            force.Normalize();
            rb.AddForce(force * magnitude);
            Die();

            //animator.SetTrigger("HitFront");
        }
    }
}
