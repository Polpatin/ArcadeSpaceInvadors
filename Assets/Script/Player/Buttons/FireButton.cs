using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Laser;
public class FireButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject LaserPrefab;
    public GameObject Player;
    public AudioSource LaserSound;
    private bool isButtonPressed = false;

    void Update()
    {
        if (isButtonPressed==true)
        {
            if (LaserShot.laserRechaeged == true)
            {
                Instantiate(LaserPrefab,Player.transform.position, LaserPrefab.transform.rotation);
                LaserSound.Play();
                LaserShot.laserRechaeged = false;
                Debug.Log("Try to shot");
            }
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isButtonPressed = true;
        Debug.Log("Button pressed");
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isButtonPressed = false;
        Debug.Log("Button unpressed");
    }
}
