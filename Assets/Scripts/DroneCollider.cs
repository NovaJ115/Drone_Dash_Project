using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneCollider : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject drone;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision happened apparently");
        if(collision.gameObject.CompareTag("Hazard"))
        {
            gameOverScreen.SetActive(true);
            drone.SetActive(false);
            Time.timeScale = 0;
            Debug.Log("Collision happened");
        }
    }


}
