using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalInput, speed;
    private float xRange = 15;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
           transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        if(transform.position.x > xRange)
           transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
           
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //launch a projectile from the player
            Instantiate(projectilePrefab, transform.position + new Vector3(0, 1, 0), projectilePrefab.transform.rotation);
        }
    }
}
