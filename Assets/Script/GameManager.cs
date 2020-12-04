using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public GameObject CameraManager;
    public GameObject PinManager;
    public GameObject MainBall;

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
            Reset();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            CameraManager.GetComponent<CameraManager>().ShowOverheadView();
        }
    }

    public void Reset()
    {
        MainBall.GetComponent<BowlingBall>().Reset();       // 공 원위치
        PinManager.GetComponent<PinManager>().Reset();      // 볼링핀 원위치
        CameraManager.GetComponent<CameraManager>().ShowMainView(); // 메인 카메라로 전환
    }

    public int GetNumFellDownPins()
    {
        return PinManager.GetComponent<PinManager>().GetNumFelldownPins();
    }
}
