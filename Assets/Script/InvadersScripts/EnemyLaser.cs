using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MisteryInTheSky;
public class EnemyLaser : MonoBehaviour
{
    public GameObject LaserPrefab;
    float startShot;
    float repetShot;
    public AudioSource LaserSound;
    // Start is called before the first frame update
    void Start()
    {
        startShot = Random.Range(5f, 20f);
        repetShot = Random.Range(7f, 15f);
        InvokeRepeating("LaserShot", startShot, repetShot);
        
        
            
    }

    // Update is called once per frame
    void Update()
    {
       


    }
    void LaserShot()
    {
        Instantiate(LaserPrefab, transform.position, LaserPrefab.transform.rotation);
        LaserSound.Play();
        
    }
   

}
