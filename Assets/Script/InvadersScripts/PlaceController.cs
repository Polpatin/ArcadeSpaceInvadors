using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InvadersAndPositions;
public class PlaceController : MonoBehaviour
{
    public Transform currentPlace;
    public bool isPlaceTacken = true;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (isPlaceTacken == false)
        {
            SendMessage();
        }




    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            isPlaceTacken = true;
            InvaderTackePosition.staticMessage = null;
            Debug.Log("Stop send message");
        }
        else
        {
            isPlaceTacken = false;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            isPlaceTacken = false;
        }

    }
   
    void SendMessage()
    {

        if (isPlaceTacken == false)
        {
            InvaderTackePosition.staticMessage = currentPlace.transform;
            Debug.Log("Sending mtssage: " + currentPlace.name+"is emtty");
            
        }
    }
   

}
