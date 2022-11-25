using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public static class SwitchCamera
{
    static List<CinemachineVirtualCamera> cameras = new List<CinemachineVirtualCamera>();

    public static CinemachineVirtualCamera activeCamera = null;

    public static bool isActive(CinemachineVirtualCamera camera)
    {
        return camera == activeCamera;
    }

    public static void switchCamera(CinemachineVirtualCamera camera)
    {
        camera.Priority = 10;
        activeCamera = camera;

        // Checking camera list
        foreach (CinemachineVirtualCamera item in cameras)
        {
            if (item != camera && item.Priority != 0)
            {
                item.Priority = 0;
            }
        }
    }


    // Register Camera 
    public static void _Register (CinemachineVirtualCamera camera)
    {
        cameras.Add(camera);
        Debug.Log(camera);
    }

    // Unregister Camera 
    public static void _Unregister(CinemachineVirtualCamera camera)
    {
        cameras.Remove(camera);
        Debug.Log(camera); 
    }


}
   
