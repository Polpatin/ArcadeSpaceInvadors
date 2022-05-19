using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Laser
{
    public class LaserShot : MonoBehaviour
    {
       
        public GameObject LaserPrefab;      
        public static bool laserRechaeged = true;
        public AudioSource LaserSound;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (laserRechaeged == true)
                {
                    Instantiate(LaserPrefab, transform.position, LaserPrefab.transform.rotation);
                    LaserSound.Play();
                    laserRechaeged = false;
                }
            }
        }

    }
}
