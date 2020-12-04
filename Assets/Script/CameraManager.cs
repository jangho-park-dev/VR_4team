using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance = null;
    public Camera firstPersonCamera;
    public Camera overheadCamera;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    public void ShowOverheadView()
    {
        firstPersonCamera.enabled = false;
        overheadCamera.enabled = true;
    }

    public void ShowMainView()
    {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;
    }
}
