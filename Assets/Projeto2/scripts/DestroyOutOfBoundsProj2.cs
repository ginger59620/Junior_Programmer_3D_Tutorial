using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsProj2 : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if an object goes past the player, removes it
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }else if (transform.position.z < lowerBound) 
        {
            Debug.Log("Game over");
            Destroy(gameObject);
        }
    }
}
