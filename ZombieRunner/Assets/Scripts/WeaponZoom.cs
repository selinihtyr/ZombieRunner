using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] FirstPersonController fpsController;

    [SerializeField] float zoomedOutFOV = 40f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity= 5f;


    bool zoomedInToggle = false;


    public void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomedInFOV;
                fpsController.RotationSpeed = zoomInSensitivity;
                fpsController.RotationSpeed = zoomInSensitivity;
            }
            else
            {
                zoomedInToggle = false;
                fpsCamera.fieldOfView = zoomedOutFOV;
                fpsController.RotationSpeed = zoomOutSensitivity;
                fpsController.RotationSpeed = zoomOutSensitivity;
            }
        }
    }
}


