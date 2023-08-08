using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneCollider : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject drone;

    public QuestionManager questionManager;

    public ScoreManager scoreManager;

    public DroneController droneController;
    public ScrollerController scrollerController;
    public SpawnerController spawnerController;

    public bool dead;

    public AudioSource droneFlyingSound;
    public AudioSource crashSound;
    public AudioSource coinCollectSound;

    public void Start()
    {
        dead = false;
        droneFlyingSound.Play();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision happened apparently");
        if(collision.gameObject.CompareTag("Hazard"))
        {
            spawnerController.gameStart = false;
            crashSound.Play();
            gameOverScreen.SetActive(true);
            //drone.SetActive(false);
            droneController.droneHitbox.gameObject.GetComponent<Rigidbody2D>().gravityScale = 2.5f;
            droneController.droneHitbox.enabled = false;
            scrollerController.StopScrolling();
            
            Debug.Log("Collision happened");
            dead = true;
        }
        if (collision.gameObject.CompareTag("Question"))
        {
            coinCollectSound.Play();
            questionManager.OpenQuestionMenu();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Coin"))
        {
            coinCollectSound.Play();
            scoreManager.score += 100;
            Destroy(collision.gameObject);
            scoreManager.StartOneHundred();
            scoreManager.coinAmount += 1;
        }
    }

    public void Update()
    {
        if (dead == true)
        {
            droneFlyingSound.Stop();
        }
    }

}
