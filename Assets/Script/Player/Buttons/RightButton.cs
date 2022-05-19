using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class RightButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject Player;
    private bool isButtonPressed = false;
    private float speed = 14f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isButtonPressed == true)
        {
            Player.transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isButtonPressed = true;

    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isButtonPressed = false;

    }

}