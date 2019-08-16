using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    float currentSpeed = -5f;

    void FixedUpdate()
    {        
        Vector3 pos = transform.position;        
        pos.x += currentSpeed * Time.deltaTime;        
        transform.position = pos;        
    }
}
