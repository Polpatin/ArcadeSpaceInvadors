using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Laser;
public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBorderY = 5.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > topBorderY)
        {
            Destroy(gameObject);
            LaserShot.laserRechaeged = true;
        }

       
    }
   
}
