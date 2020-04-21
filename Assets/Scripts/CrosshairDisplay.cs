using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairDisplay : MonoBehaviour
{
    public CinemachineFreeLook throwCamera;
    public GameObject crosshair;

    void Update() {
        crosshair.SetActive(CinemachineCore.Instance.IsLive(throwCamera));
    }

}
