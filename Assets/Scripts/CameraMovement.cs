using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject crosshairComponent;
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    public float smoothFactor = 10f;
    public float rotationSpeed = 5.0f;
    public Transform zoomPosition;
    public Vector3 startingPos;
    private Vector3 offset;
    private Quaternion startingRotation;
    private float xRotation = 0f;
    private bool inZoom;

    // Start is called before the first frame update
    void Start()
    {   
        startingRotation = transform.localRotation;
        startingPos = transform.localPosition;
        ToggleCrosshair(false);
    }

    void Update() {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        if (inZoom) {
            transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
            playerBody.Rotate(Vector3.up * mouseX);
        }
    }

    void ToggleCrosshair(bool enable) {
        SimpleCrosshair crosshair = crosshairComponent.GetComponent<SimpleCrosshair>();
        if (crosshairComponent) {
            crosshairComponent.SetActive(enable);
        }
    }

    void LateUpdate() {
        if (Input.GetMouseButton(1)) {
            Cursor.lockState = CursorLockMode.Locked;
            inZoom = true;
            transform.localPosition = Vector3.Lerp(transform.localPosition, zoomPosition.localPosition, smoothFactor * Time.deltaTime);
            ToggleCrosshair(true);
        }
        if (Input.GetMouseButtonUp(1)) {
            inZoom = false;
            Cursor.lockState = CursorLockMode.None;
            transform.localPosition = startingPos;
            transform.localRotation = startingRotation;
            ToggleCrosshair(false);
        }
    }
}

