using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreGainer : MonoBehaviour
{
    GameController controller;
    public ParticleSystem hitEffect;

    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            controller.Scored();
            hitEffect.Play();
        }        
    }
}
