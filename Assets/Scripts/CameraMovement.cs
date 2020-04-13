using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothFactor = 0.5f;
    public float rotationSpeed = 5.0f;
    private Vector3 offset;
    private Quaternion startingRotation;
    // Start is called before the first frame update
    void Start()
    {   
        offset = transform.position - target.position;
        startingRotation = transform.rotation;
    }

    // Update is called once per frame
    void LateUpdate() {
        if (Input.GetMouseButton(1)) {
            Quaternion camTurnAngleX = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up);
            Quaternion camTurnAngleY = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * rotationSpeed, Vector3.left);
            offset = camTurnAngleX * camTurnAngleY * offset;
            Vector3 newPos = target.position + offset;
            transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);
        }
        // Vector3 zoomPos = transform.position * Input.GetAxis("Mouse ScrollWheel") * 5;
        //transform.position = Vector3.Slerp(transform.position, zoomPos, smoothFactor);
        transform.LookAt(target);
    }
}

