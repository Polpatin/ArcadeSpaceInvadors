using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;
public class EnemyCheckOnScene : MonoBehaviour
{
    bool isPlayerWin = false;
    float timer = 3;
    public GameObject MisteryShip;
    private void Update()
    {
        CountDounToWin();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            isPlayerWin = false;
            timer = 3;
        }
    }
    void CountDounToWin()
    {
        timer-=Time.deltaTime;
        if(timer<0)
        {
            //SceneManager.LoadScene(2);
            MisteryShip.SetActive(true);
        }
    }
}
