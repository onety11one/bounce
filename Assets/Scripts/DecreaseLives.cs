using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseLives : MonoBehaviour
{
    GameController controller;

    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {            
            controller.lives--;
            controller.livesText.text = "Lives: " + controller.lives.ToString();
            this.gameObject.SetActive(false);            
        }
    }
}
