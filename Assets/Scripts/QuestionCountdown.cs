using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionCountdown : MonoBehaviour
{

    public TextMeshProUGUI timerText;
    public float timeAmount;
    public GameObject questionMenu;
    

    public float time;
    void Start()
    {
        time = timeAmount;
    }

    void Update()
    {

        timerText.text = "Next Question: " + Mathf.RoundToInt(timeAmount);
        timeAmount -= 1f * Time.deltaTime;
        if(timeAmount <= 0)
        {
            timeAmount = 0;
        }
        if (timeAmount == 0)
        {
            questionMenu.SetActive(true);
            Time.timeScale = 0;
        }
        Debug.Log(timeAmount);
    }

    
}
