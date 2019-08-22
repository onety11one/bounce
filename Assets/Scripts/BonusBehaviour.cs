using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBehaviour : MonoBehaviour
{
    public float rotSpeed = 5f;
    public float vertSpeed = 2f;
    public bool isLife;
    Vector3 newPosition;
    GameController controller;
    PlayerMovement pMove;

    void Start()
    {
        pMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        controller = GameObject.Find("GameController").GetComponent<GameController>();
        transform.rotation = Quaternion.Euler(-90, 0, 0);        
    }
    void Update()
    {
        newPosition = transform.position;
        newPosition.y += Mathf.Sin(Time.time) * Time.deltaTime;
        transform.position = newPosition;

        transform.Rotate(Vector3.back, rotSpeed * Time.deltaTime);        
    }   

    public void OnTriggerEnter(Collider other)
    {        
        if (other.gameObject.tag == "Player" && isLife == true)
        {
            pMove.PlayEffect();
            controller.GainLife();
            Destroy(this.gameObject);
        }
        else if (other.gameObject.tag == "Player" && isLife == false)
        {
            controller.GainCoin();
            Destroy(this.gameObject);
        }
        
    }
}
