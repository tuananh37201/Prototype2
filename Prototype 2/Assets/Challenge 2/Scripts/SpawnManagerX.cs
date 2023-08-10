using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[Random.Range(0,3)], spawnPos, ballPrefabs[0].transform.rotation);

        //spawnInterval is called each time "SpawnRandomBall" is called. Needs to be 3,6 as it will allow for values of 3,4 and 5. 
        int spawnInterval = Random.Range(3, 6);

        //Call the method and adds the spawnInterval, which is now generated at random. 
        Invoke("SpawnRandomBall", spawnInterval);
    }
}
