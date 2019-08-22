using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float bouncy = 5f;
    float rotSpeed = 5f;
    public GameObject bottom;
    public ParticleSystem getLifePrefab;
    public ParticleSystem loseLifePrefab;
    GameController controller;

    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
    }

    void FixedUpdate()
    {
        transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);

        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, bouncy * Time.deltaTime, 0);
        pos += transform.rotation * velocity;

        transform.position = pos;

        if (transform.position.y >= 13 || transform.position.y <= -8)
        {
            Destroy(gameObject);
            controller.GameOver();
        }

        if (transform.position.y <= -7.17 && controller.lives > 0)
        {
            loseLifePrefab.Play();
            bottom.SetActive(true);
        }
    }

    public void PlayEffect()
    {
        getLifePrefab.Play();
    }
}
