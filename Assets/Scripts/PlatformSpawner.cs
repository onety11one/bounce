using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject[] platformPrefab;    

    void Start()
    {
        StartCoroutine(SpawnFigure());        
    }

    IEnumerator SpawnFigure()
    {
        while (true)
        {
            Instantiate(platformPrefab[Random.Range(0, platformPrefab.Length)], transform.position, transform.rotation);
            yield return new WaitForSeconds(Random.Range(3, 7));
        }
        
    }
}
