using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformColorRandomizer : MonoBehaviour
{
    public GameObject[] background;
    Color randColor;
    float startTime;
    ChangeColor changeColor;

    void Start()
    {
        startTime = Time.time;
        randColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        if (Random.value < 0.6)
        {
            GetComponent<Renderer>().material.color = randColor;
        }        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && GetComponent<Renderer>().material.color == randColor)
        {            
            foreach (var bg in background)
            {
                bg.GetComponent<Renderer>().sharedMaterial.color = randColor;                
            }
        }
    }    
}