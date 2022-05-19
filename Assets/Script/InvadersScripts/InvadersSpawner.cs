using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersSpawner : MonoBehaviour
{

    static public int randomIndex;
    public GameObject[] invadersPrefab;
    float startSpawn;
    float repetSpawn;
    // Start is called before the first frame update
    //if place is triggered not go to place
    void Start()
    {
        startSpawn = Random.Range(4f, 10f);
        repetSpawn = Random.Range(3f, 5f);
        InvokeRepeating("SpawnInwador", startSpawn, repetSpawn);
    }

    // Update is called once per frame
   
    void SpawnInwador()
    {
            randomIndex = Random.Range(0, invadersPrefab.Length);
            Instantiate(invadersPrefab[randomIndex]);
          
      
    }
   


}
