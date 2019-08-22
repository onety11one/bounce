using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreGainer : MonoBehaviour
{
    bool wasHit;
    GameController controller;
    public ParticleSystem hitEffect;

    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
        //hitEffect.GetComponent<ParticleSystem>().startColor = 
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && wasHit == false)
        {
            wasHit = true;
            controller.GainScore();
            hitEffect.Play();
        }
    }
}
