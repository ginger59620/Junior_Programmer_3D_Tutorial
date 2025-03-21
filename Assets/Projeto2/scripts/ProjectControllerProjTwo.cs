using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectControllerProjTwo : MonoBehaviour
{
    public float HorizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public GameObject porjectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Keep the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(porjectilePrefab, transform.position, porjectilePrefab.transform.rotation);
        }
    }
}
