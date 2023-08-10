using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBF : MonoBehaviour
{
    public GameObject projectilesPrefab;

    private float horizontalInput;
    private float verticalInput;

    public float speedX = 20f;
    public float speedZ = 10f;

    public float boundX = 11.5f;
    public float boundTopZ = 13f;
    public float boundBottomZ = 2.3f;

    public int maxHealth = 3;
    public int currentHealth = 0;

    public float delay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        Debug.Log("Lives = " + currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        // Movement Bound
        if (transform.position.x > boundX)
        {
            transform.position = new Vector3(boundX, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -boundX)
        {
            transform.position = new Vector3(-boundX, transform.position.y, transform.position.z);
        }
        else if (transform.position.z < boundBottomZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, boundBottomZ);
        }
        else if (transform.position.z > boundTopZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, boundTopZ);
        }

        // Movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(horizontalInput * speedX * Time.deltaTime, 0, verticalInput * speedZ * Time.deltaTime);

        // Dead
        if (currentHealth < 1)
        {
            Debug.Log("Game Over!");
        }

        // Launch projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilesPrefab, transform.position + new Vector3(0f, 0f, 0.9f), projectilesPrefab.transform.rotation);
        }

        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Lives = " + currentHealth);
        currentHealth = currentHealth - 1;
    }
}
