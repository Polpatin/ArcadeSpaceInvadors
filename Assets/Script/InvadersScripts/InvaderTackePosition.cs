using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace InvadersAndPositions
{
    public class InvaderTackePosition : MonoBehaviour
    {
        //  public GameObject EmtyPlace;
        float speed = 3.5f;

        public static Transform staticMessage = null;
        Transform target = null;
        bool isMessegeDelivered = false;
        bool tackePosition = false;
        // Start is called before the first frame update
        void Start()
        {

            // InvokeRepeating("GetMassage", 2, 1);
            Debug.Log("Start is working");
            // staticMessage = null;
            target = null;
            isMessegeDelivered = false;
            tackePosition = false;

            GetMassage();
        }

        // Update is called once per frame
        void Update()
        {

            if (tackePosition == true)
            {
                float step = speed * Time.deltaTime;

                transform.position = Vector2.MoveTowards(transform.position, target.position, step);

            }
        }
        void GetMassage()
        {
            if (isMessegeDelivered == false)
            {
                if (staticMessage != null)
                {

                    isMessegeDelivered = true;
                    CopyPath();
                    // Debug.Log("Message delivered");

                }
                else if (staticMessage == null)
                {
                    Destroy(gameObject);
                    Debug.Log("Invader dont have any place, so destroyed");
                }
            }      
        }
        void CopyPath()
        {
            target = staticMessage;//скопировал
            tackePosition = true;
        }
    }
}