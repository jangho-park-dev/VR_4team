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
}
