using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using InvadersAndPositions;
using Miror;
public class TurnToKamikadze : MonoBehaviour
{
    float speedRotation;
    bool isReadyToDeath=false;
    float step=1f;
    public AudioSource SawSound;
    float secToTurnKamikadze;
    bool isSoundPlay = false;
    // Start is called before the first frame update
    void Start()
    {

       secToTurnKamikadze= Random.Range(14,28);
        InvokeRepeating("BecameKamikadze", secToTurnKamikadze, 0);
       
        
    }

    // Update is called once per frame
    void Update()
    {
        StartRotate();
    }
   
   void StartRotate()
    {
        if (isReadyToDeath == true)
        {
            
            speedRotation++;
            transform.Rotate(0, 0, speedRotation);
            if(speedRotation>60)
            {
                speedRotation = 60;
                TurnToRed();
                LetGoPlace();
                FlyToDeath();
            }
        }
    }
    void TurnToRed()
    {
      
        GetComponent<SpriteRenderer>().color = new Color(164, 0, 0, 255);

    }
    void LetGoPlace()
    {

        GetComponent<InvaderTackePosition>().enabled = false;

    }
    void FlyToDeath()
    {
       
            transform.position = Vector2.MoveTowards (transform.position, MirorCoordinats.miror.position, step);  
    }
    void BecameKamikadze()
    {
        PlaySound();

        isReadyToDeath = true;
    }
    void PlaySound()
    {

        if(isSoundPlay==false)
        {
            Instantiate(SawSound);
            isSoundPlay = true;
        }
    }
}
