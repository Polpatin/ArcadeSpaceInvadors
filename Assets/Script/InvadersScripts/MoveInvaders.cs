using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInvaders : MonoBehaviour
{
    float speed = 5f;
    int invaderStepsAmount=8;
    bool moveRigt = true;
    bool moveLeft = false;
    bool moveDown = false;
    int counterRight;
    int counterLeft;
    int counterDown;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MoveInvadersLeftToRight", 1f, 1f);
        moveRigt = true;
        moveLeft = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void MoveInvadersLeftToRight()
    {
       
        MoveRight();
        MoveLeft();
        

    }
    void MoveRight()
    {
        if(counterRight< invaderStepsAmount & moveRigt==true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            counterRight++;
        }
        else if(counterRight>= invaderStepsAmount)
        {
            moveRigt = false;
            moveLeft = true;
            counterRight = 0;

            moveDown = true;
            MoveDown();
        }

    }
    void MoveLeft()
    {

        if (counterLeft < invaderStepsAmount & moveLeft == true)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            counterLeft++;
        }
        else if(counterLeft>= invaderStepsAmount & moveLeft==true)
        {
            moveRigt =true;
            moveLeft = false;
            counterLeft = 0;
            moveDown = true;
            MoveDown();
        }
    }
    void MoveDown()
    {
        if (moveDown == true & counterDown<6)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            moveDown = false;
            counterDown++;
        }
    }
}
