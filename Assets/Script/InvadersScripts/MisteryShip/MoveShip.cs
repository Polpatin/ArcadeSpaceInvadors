using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MisteryInTheSky
{
    public class MoveShip : MonoBehaviour
    {
        public float speed = 5f;
        bool mooveRight = false;
        bool mooveLeft = false;
        float border = 21;
        public static bool isMisteryInTheSky;
        // Start is called before the first frame update
        void Start()
        {
            isMisteryInTheSky = true;
            mooveLeft = true;
            InvokeRepeating("ChangeSpeed", 3, 3);
        }

        // Update is called once per frame
        void Update()
        {
            if (transform.position.x <= -border)
            {
                mooveRight = true;
                mooveLeft = false;
            }
            if (transform.position.x >= border)
            {
                mooveLeft = true;
                mooveRight = false;
            }
            MovwLeft();
            MoveRight();
        }
        void MovwLeft()
        {
            if (mooveLeft == true)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
        }
        void MoveRight()
        {
            if (mooveRight == true)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }
        void ChangeSpeed()
        {
            speed = Random.Range(5, 9);
        }

    }
}