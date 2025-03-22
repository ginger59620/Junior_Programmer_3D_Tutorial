using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftProj3 : MonoBehaviour
{
    private float speed = 30;

    private PlayerControllerProj3 playerControllerProj3Script;

    private float leftBound = -15;


    // Start is called before the first frame update
    void Start()
    {
        playerControllerProj3Script = GameObject.Find("Player").GetComponent<PlayerControllerProj3>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerProj3Script.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
