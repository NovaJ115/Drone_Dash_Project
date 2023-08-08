using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public float score;
    public float scorePerSecond;

    public GameObject oneHundredScoreText;
    public GameObject oneHundredFiftyScoreText;
    public GameObject minusFiftyScoreText;

    public TextMeshProUGUI coinAmontText;
    public int coinAmount;

    public float highScore;
    public float theCurrentHighScore;

    public DroneCollider droneCollider;
    public void Start()
    {
        coinAmount = PlayerPrefs.GetInt("Coins");
        if (PlayerPrefs.HasKey("Highscore"))
        {
            highScore = PlayerPrefs.GetFloat("Highscore");
        }
    }

    void Update()
    {
        scoreText.text = ("Score : " + Mathf.RoundToInt(score));
        if (droneCollider.dead == false)
        {
            score += scorePerSecond * Time.deltaTime;
        }
        

        PlayerPrefs.SetInt("Coins", coinAmount);

        coinAmontText.text = ": " + PlayerPrefs.GetInt("Coins");

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetFloat("Highscore", Mathf.RoundToInt(highScore));
        }

        theCurrentHighScore = PlayerPrefs.GetFloat("Highscore");
        Debug.Log(theCurrentHighScore);
    }

    public IEnumerator OneHundredScore()
    {
        yield return new WaitForSeconds(1.5f);
        oneHundredScoreText.SetActive(false);
        StopAllCoroutines();
    }
    public IEnumerator OneHundredFiftyScore()
    {
        yield return new WaitForSeconds(1.5f);
        oneHundredFiftyScoreText.SetActive(false);
        StopAllCoroutines();
    }
    public IEnumerator MinusFiftyScore()
    {
        yield return new WaitForSeconds(1.5f);
        minusFiftyScoreText.SetActive(false);
        StopAllCoroutines();
    }

    public void StartOneHundred()
    {
        oneHundredScoreText.SetActive(true);
        StartCoroutine(OneHundredScore());
    }
    public void StartOneHundredFifty()
    {
        oneHundredFiftyScoreText.SetActive(true);
        StartCoroutine(OneHundredFiftyScore());
    }
    public void StartMinusFifty()
    {
        minusFiftyScoreText.SetActive(true);
        StartCoroutine(MinusFiftyScore());
    }

   

}
