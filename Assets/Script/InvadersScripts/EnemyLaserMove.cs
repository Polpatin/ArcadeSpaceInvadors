using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserMove : MonoBehaviour
{
    public float speed = 8f;
    private float bottomBorderY = -5.5f;
    public GameObject LaserExplode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y < bottomBorderY)
        {
            Destroy(gameObject);
           
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ExplosionIsBegin();


        }
        if (collision.gameObject.tag == "Dota")
        {
            Destroy(gameObject);
            ExplosionIsBegin();

        }
    }
    void ExplosionIsBegin()
    {
        Instantiate(LaserExplode, transform.position, LaserExplode.transform.rotation);

    }
}
