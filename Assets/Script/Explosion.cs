using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float explosionTime = 0;
    float explosionDeathTime = 3f;
   
    // Start is called before the first frame update
    void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        explosionTime = explosionTime + 1;
        if (explosionTime >= explosionDeathTime)
        {
           
            explosionTime = 0;
           
            Destroy(gameObject);
        }
    }

}
