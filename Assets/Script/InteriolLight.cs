using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteriolLight : MonoBehaviour
{
    public Color startColor;
    public Color endColor;
    bool isTurnOn = true;
    float interpolate = 0.0f; // 0.0 ~ 1.f
    float randomSpeed;

    void Start()
    {
        randomSpeed = Random.Range(0.3f, 1.5f);
        GetComponent<Light>().color = startColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTurnOn)
        {
            interpolate += Time.deltaTime * randomSpeed;
            if (interpolate > 1)
                isTurnOn = false;
        }
        else
        {
            interpolate -= Time.deltaTime * randomSpeed;
            if (interpolate < 0)
                isTurnOn = true;
        }

        GetComponent<Light>().color = Color.Lerp(startColor, endColor, interpolate);
    }
}
