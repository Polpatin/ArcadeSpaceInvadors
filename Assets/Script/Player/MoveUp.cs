using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Laser;
using ScoreCount;
public class MoveUp : MonoBehaviour
{
    public float speed = 12f;
    public GameObject LaserExplode;
    float explosionTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position = Explosion.LaserStaticCoordinats;
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dota")
        {
            ExplosionIsBegin();
            Destroy(gameObject);
            LaserShot.laserRechaeged = true;
          
        }
       else if (collision.gameObject.tag == "Enemy")
        {
            ExplosionIsBegin();
            Destroy(gameObject);
            LaserShot.laserRechaeged = true;
            Score.score++;
        }
    }
    void ExplosionIsBegin()
    {
        Instantiate(LaserExplode , transform.position, LaserExplode.transform.rotation);
      
    }
   
}
