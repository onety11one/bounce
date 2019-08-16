using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawner : MonoBehaviour
{
    public GameObject bunusPrefab;
    public float spawnStart;
    public float spawnDelay;

    void Start()
    {                
        InvokeRepeating("SpawnBonus", spawnStart, spawnDelay);
    }

    void SpawnBonus()
    {
        Instantiate(bunusPrefab, transform.position, transform.rotation);
    }
}
