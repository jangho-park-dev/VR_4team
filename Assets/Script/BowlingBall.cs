using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    Vector3 startPos;
    Quaternion startRotation;
    // Start is called before the first frame update
    void Start()
    {
        startPos = GetComponent<Transform>().position;
        startRotation = GetComponent<Transform>().rotation;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Reset()
    {
        GetComponent<Transform>().position = startPos;
        GetComponent<Transform>().rotation = startRotation;
    }
}
