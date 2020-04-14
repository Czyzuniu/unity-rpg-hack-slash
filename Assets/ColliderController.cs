using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{

    void Start() {
        Physics.IgnoreLayerCollision(8,8);
    }


    void OnTriggerEnter(Collider collider) {
        print("I have hit " + collider.gameObject.name);
    }
}
