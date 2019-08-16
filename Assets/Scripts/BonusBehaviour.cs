using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBehaviour : MonoBehaviour
{
    public float rotSpeed = 5f;
    public float vertSpeed = 2f;
    Vector3 newPosition;
    GameController controller;

    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
        transform.rotation = Quaternion.Euler(90,0,0);        
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
        if (other.gameObject.tag == "Player")
        {
            controller.GainLife();
            Destroy(this.gameObject);
        }
    }
}
