using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public float score;
    public float scorePerSecond;
    
    void Update()
    {
        scoreText.text = ("Score : " + Mathf.RoundToInt(score));
        
        score += scorePerSecond * Time.deltaTime;

        
    }
}
