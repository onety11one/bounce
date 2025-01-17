﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformColorRandomizer : MonoBehaviour
{    
    Color randColor;
    float startTime;
    GameController controller;

    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
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
            controller.SetBackground(randColor);
        }
        else if (collision.gameObject.tag == "Player")
        {
            controller.SetBackground(Color.white);
        }
    }    
}