using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteriolLight : MonoBehaviour
{
    public Color startColor;
    public Color endColor;
    bool isTurnOn = true;
    float interpolate = 0.0f; // 0.0 ~ 1.f

    void Start()
    {
        GetComponent<Light>().color = startColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTurnOn)
        {
            interpolate += Time.deltaTime * 0.5f;
            if (interpolate > 1.0f)
                isTurnOn = false;
        }
        else
        {
            interpolate -= Time.deltaTime * 0.5f;
            if (interpolate < 0.0f)
                isTurnOn = true;
        }

        GetComponent<Light>().color = Color.Lerp(startColor, endColor, interpolate);
    }
}
