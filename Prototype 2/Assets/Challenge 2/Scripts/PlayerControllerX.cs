using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float delayTime = 2f;
    private float lastKeyPressTime = 0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Time.time - lastKeyPressTime >= delayTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                lastKeyPressTime = Time.time;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
        
    }
}
