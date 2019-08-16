using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float bouncy = 5f;
    public GameObject bottom;
    GameController controller;    

    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
    }

    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, bouncy * Time.deltaTime, 0);
        pos += transform.rotation * velocity;     

        transform.position = pos;
        
        if (transform.position.y >= 13 || transform.position.y <= -8)
        {
            Destroy(gameObject);
            controller.GameOver();
        }

        if (transform.position.y <=-7.17 && controller.lives > 0)
        {
            bottom.SetActive(true);
        }        
    }
}
