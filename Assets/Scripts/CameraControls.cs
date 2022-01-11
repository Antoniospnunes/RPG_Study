using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraControls : MonoBehaviour
{
    protected CinemachineFreeLook cameraController;
    protected CinemachineCollider cameraCollider;

    protected Player_Controller playerController;

    private void Awake()
    {
        cameraController = GetComponent<CinemachineFreeLook>();
        cameraCollider = GetComponent<CinemachineCollider>();
        playerController = new Player_Controller();
    }

    protected void OnEnable()
    {
        playerController.Enable();
    }

    protected void OnDisable()
    {
        playerController.Disable();
    }

    private void Start()
    {
        playerController.Click_Controller.CameraControl.performed += _ => ControlCamera();
        playerController.Click_Controller.CameraControl.canceled += _ => StopControllingCamera();

        StopControllingCamera();
    }

    private void Update()
    {
        ZoomControl();
    }

    private void ControlCamera()
    {
        Cursor.visible = false;

        cameraController.m_YAxis.m_InputAxisName = "Mouse Y";
        cameraController.m_XAxis.m_InputAxisName = "Mouse X";
    }

    private void StopControllingCamera()
    {
        cameraController.m_YAxis.m_InputAxisName = "";
        cameraController.m_XAxis.m_InputAxisName = "";
        cameraController.m_YAxis.m_InputAxisValue = 0;
        cameraController.m_XAxis.m_InputAxisValue = 0;

        Cursor.visible = true;
        
    }

    private void ZoomControl()
    {
        if (playerController.Click_Controller.CameraZoom.ReadValue<Vector2>().y > 0)
        {
            if (cameraController.m_Orbits[1].m_Radius > 12)
            {
                cameraController.m_Orbits[0].m_Height -= 1f;
                cameraController.m_Orbits[1].m_Radius -= 1f;
                cameraController.m_Orbits[2].m_Radius -= 1f;
                /*if(cameraCollider.m_MinimumDistanceFromTarget > 5)
                {
                    cameraCollider.m_MinimumDistanceFromTarget -= 1;
                }*/
            }
        }
        else if (playerController.Click_Controller.CameraZoom.ReadValue<Vector2>().y < 0)
        {
            if (cameraController.m_Orbits[1].m_Radius < 40f)
            {
                cameraController.m_Orbits[0].m_Height += 1f;
                cameraController.m_Orbits[1].m_Radius += 1f;
                cameraController.m_Orbits[2].m_Radius += 1;
                /*if (cameraCollider.m_MinimumDistanceFromTarget < 15)
                {
                    cameraCollider.m_MinimumDistanceFromTarget += 1;
                }*/
            }
        }
    }
}
