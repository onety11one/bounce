using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public float speed = 1.0f;
    Color startColor;
    Color endColor;    
    float startTime;
    
    void Start()
    {
        startTime = Time.time;
        startColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        endColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    void Update()
    {       
        float t = (Mathf.Sin(Time.time - startTime) * speed);
        GetComponent<Renderer>().sharedMaterial.color = Color.Lerp(startColor, endColor, t);
       
    }
}