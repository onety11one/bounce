using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawningObjects : MonoBehaviour
{
    public GameObject playerPlatformPrefab;

    Vector2 screenToWorld;

    void Update()
    {
        screenToWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began || Input.GetMouseButtonDown(0))
        {
            Instantiate(playerPlatformPrefab, screenToWorld, Quaternion.identity);
        }
    }
}
