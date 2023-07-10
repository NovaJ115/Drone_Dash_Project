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

    public void Start()
    {
        
    }

    void Update()
    {
        scoreText.text = ("Score : " + Mathf.RoundToInt(score));
        
        score += scorePerSecond * Time.deltaTime;

    }

    public IEnumerator OneHundredScore()
    {
        yield return new WaitForSeconds(3);
        oneHundredScoreText.SetActive(false);
        StopAllCoroutines();
    }
    public IEnumerator OneHundredFiftyScore()
    {
        yield return new WaitForSeconds(3);
        oneHundredFiftyScoreText.SetActive(false);
        StopAllCoroutines();
    }
    public IEnumerator MinusFiftyScore()
    {
        yield return new WaitForSeconds(3);
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
