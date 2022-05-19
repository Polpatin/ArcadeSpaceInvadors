using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public GameObject Heart4;
    public GameObject Heart5;

    int health = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;

            IsPlayerDeath();
        }
        if (collision.gameObject.tag == "EnemyLaser")
        {
            health--;
            HeartsDisplay();
            IsPlayerDeath();
        }

    }
    void IsPlayerDeath()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(1);
           
        }
    }
    void HeartsDisplay()
    {
        if(health==4)
        {
            Heart5.SetActive(false);
        }
       else if (health == 3)
        {
            Heart4.SetActive(false);
        }
        else if (health == 2)
        {
            Heart3.SetActive(false);
        }
        else if (health == 1)
        {
            Heart2.SetActive(false);
        }
        else if (health == 0)
        {
            Heart1.SetActive(false);
        }

    }
}
