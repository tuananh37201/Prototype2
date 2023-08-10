using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerBF : MonoBehaviour
{
    public GameObject[] dogPrefabs;
    private float spawnRangeX = 11;
    private float spawnPosZ = 15;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        int animalIndex = Random.Range(0, dogPrefabs.Length);

        Instantiate(dogPrefabs[animalIndex], spawnPos, dogPrefabs[animalIndex].transform.rotation);
    }
}
