using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class MisterySound : MonoBehaviour
    {
        public GameObject MisteryShip;
        public AudioSource misterySound;
        float startShipPositionX;
        
        // Start is called before the first frame update
        void Start()
        {
            
            startShipPositionX = MisteryShip.transform.position.x;
        }

        // Update is called once per frame
        void Update()
        {

            if (MisteryShip.transform.position.x > 0)
            {
                misterySound.volume = 1 - (1 / startShipPositionX * MisteryShip.transform.position.x);
            }
            else if (MisteryShip.transform.position.x < 0)
            {
                misterySound.volume = 1 - (1 / (startShipPositionX * -1) * MisteryShip.transform.position.x);
            }
        }
    }
