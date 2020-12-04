using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinManager : MonoBehaviour
{
    public List<GameObject> pins;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        foreach (GameObject pin in pins)
        {
            pin.GetComponent<BowlingPin>().Reset();
        }
    }

    public int GetNumFelldownPins()
    {
        int numFelldownPins = 0;

        Vector3 upVector3 = new Vector3(0, 1, 0);
        foreach (GameObject pin in pins)
        {
            if (Vector3.Dot(pin.GetComponent<Transform>().forward, upVector3) < 0.9f)
                numFelldownPins++;
        }

        return numFelldownPins;
    }
}
