using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardBF : MonoBehaviour
{
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(5f, 10f);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(transform.position.z < -2)
        {
            Destroy(gameObject);
        }

    }
}
