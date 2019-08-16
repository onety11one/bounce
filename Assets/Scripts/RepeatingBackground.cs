using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    BoxCollider2D groundCollider;
    float groundHorizontalLength;
    
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x;
    }

    void Update()
    {
        if( transform.position.x < -groundHorizontalLength)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        Vector3 groundOffset = new Vector3(groundHorizontalLength * 2f, 0, 5);
        transform.position = transform.position + groundOffset;
    }
}
