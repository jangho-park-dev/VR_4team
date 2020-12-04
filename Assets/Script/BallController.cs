using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    
    public Vector3 startVelocity;
    public bool once;
    Vector3 startPos;
    Quaternion startRotation;

    // Start is called before the first frame update
    void Start()
    {
        startPos = GetComponent<Transform>().position;
        startRotation = GetComponent<Transform>().rotation;
        rb = GetComponent<Rigidbody>();
        startVelocity = new Vector3(0.0f, 0.0f, 0.0f);
        once = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.transform.position.z >= 0.0f)
        {
            if (once)
            {
                startVelocity = rb.velocity;
                once = false;
            }
            // GetComponent<Rigidbody>().velocity = Vector3.Normalize(GetComponent<Rigidbody>().velocity) * (원하는 속도);
            rb.velocity = Vector3.Normalize(rb.velocity) * startVelocity.magnitude * 3.0f;
        }

        if (rb.transform.position.z >= 20.0f)
        {
            Reset();
        }
    }

    public void Reset()
    {
        GetComponent<Transform>().position = startPos;
        GetComponent<Transform>().rotation = startRotation;
        rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
    }
}
