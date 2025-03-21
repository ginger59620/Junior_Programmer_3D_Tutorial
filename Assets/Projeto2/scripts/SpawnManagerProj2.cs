using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerProj2 : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    private float starrDelay = 2;
    private float spawnIntervel = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", starrDelay, spawnIntervel); 
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); //Randomly generate an animal index and spawn position

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
