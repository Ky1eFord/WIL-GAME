using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Cinemachine;

public class PlayerControls : MonoBehaviour
{
    [Header("GameObject")]


    [Header("CineMachine")]
    [SerializeField] CinemachineVirtualCamera thirdPersonCam;
    [SerializeField] CinemachineVirtualCamera firstPersonCam;



    [Header("Floats")]
    
    public float speed = 0.05f;

    
    private void OnEnable()
    {
        SwitchCamera._Register(thirdPersonCam);
        SwitchCamera._Register(firstPersonCam);
        SwitchCamera.switchCamera(thirdPersonCam);
    }

    private void OnDisable()
    {
        SwitchCamera._Unregister(thirdPersonCam);
        SwitchCamera._Unregister(firstPersonCam);
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Switch camera

            if (SwitchCamera.isActive(thirdPersonCam))
            {
                SwitchCamera.switchCamera(firstPersonCam);
            }
            else if (SwitchCamera.isActive(firstPersonCam))
            {
                SwitchCamera.switchCamera(thirdPersonCam);
            }
        }

        // Player Movement
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed, 0, Input.GetAxisRaw("Vertical") * speed);


    }

}
