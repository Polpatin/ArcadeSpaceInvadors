using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderContactLaser : MonoBehaviour
{
    public GameObject KamikadzeExplode;
    public AudioSource KamiExplodeSound;
    bool isSoundPlay = false;

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
        if(collision.gameObject.tag=="Laser")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            PlaySound();
            KamikadzeExplosion();
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Dota")
        {
            PlaySound();
            KamikadzeExplosion();
            Destroy(gameObject);
        }
    }
    void KamikadzeExplosion()
    {
        Instantiate(KamikadzeExplode, transform.position, KamikadzeExplode.transform.rotation);
    }
    void PlaySound()
    {

        if (isSoundPlay == false)
        {
            Instantiate(KamiExplodeSound);
            isSoundPlay = true;
        }
    }
}
