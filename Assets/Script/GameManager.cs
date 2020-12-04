using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public GameObject CameraManager;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            CameraManager.GetComponent<CameraManager>().ShowFirstPersonView();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            CameraManager.GetComponent<CameraManager>().ShowOverheadView();
        }
    }
}
