using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneCollider : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject drone;

    public QuestionManager questionManager;

    public ScoreManager scoreManager;

    public bool dead;

    public void Start()
    {
        dead = false;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision happened apparently");
        if(collision.gameObject.CompareTag("Hazard"))
        {
            gameOverScreen.SetActive(true);
            drone.SetActive(false);
            Time.timeScale = 0;
            Debug.Log("Collision happened");
            dead = true;
        }
        if (collision.gameObject.CompareTag("Question"))
        {
            questionManager.OpenQuestionMenu();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Coin"))
        {
            scoreManager.score += 100;
            Destroy(collision.gameObject);
            scoreManager.StartOneHundred();
            scoreManager.coinAmount += 1;
        }
    }


}
