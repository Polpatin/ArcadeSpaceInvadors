using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotaSpritesChanger : MonoBehaviour
{
    public Sprite spriteDota3; // Drag your first sprite here
    public Sprite spriteDota2;
    public Sprite spriteDota1;
    private SpriteRenderer spriteRenderer;

    int health =12;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = spriteDota3; // set the sprite to sprite1
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            ChangeSprites();
        }
       else if (collision.gameObject.tag == "EnemyLaser")
        {
            health--;
            ChangeSprites();
        }
      
    }
    void ChangeSprites()
    {
         switch(health)
        {
            case 9:
                spriteRenderer.sprite = spriteDota3;
                break;
            case 6:
                spriteRenderer.sprite = spriteDota2;
                break;
            case 3:
                spriteRenderer.sprite = spriteDota1;
                break;
            case 0:
                Destroy(gameObject);
                break;
        }
           
    }
}
