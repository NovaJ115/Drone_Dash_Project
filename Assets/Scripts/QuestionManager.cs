using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public GameObject questionMenu;

    public GameObject resumeTimerScreen;
    public TextMeshProUGUI timerText;
    public float timeAmount;

    public bool countdownActive;

    public float time;

    public ScoreManager scoreManager;

    public void Start()
    {
        countdownActive = false;
        time = timeAmount;
    }
    public void OpenQuestionMenu()
    {
        questionMenu.SetActive(true);
        Time.timeScale = 0;

    }
    public void ResumeCountdown()
    {
        resumeTimerScreen.SetActive(true);
        
    }


    public void TheCorrectAnswer()
    {
        StartCoroutine(CorrectAnswer());
    }
    public void TheIncorrectAnswer()
    {
        StartCoroutine(IncorrectAnswer());
    }

    public IEnumerator CorrectAnswer()
    {
        
        yield return new WaitForSecondsRealtime(2);
        
        questionMenu.SetActive(false);
        resumeTimerScreen.SetActive(true);
        timerText.text = "Resume in: 3";
        yield return new WaitForSecondsRealtime(1);
        timerText.text = "Resume in: 2";
        yield return new WaitForSecondsRealtime(1);
        timerText.text = "Resume in: 1";
        yield return new WaitForSecondsRealtime(1);
        scoreManager.score += 150;
        resumeTimerScreen.SetActive(false);
        Time.timeScale = 1;
        scoreManager.StartOneHundredFifty();
        Debug.Log("Coroutine Finished");
    }

    public IEnumerator IncorrectAnswer()
    {

        yield return new WaitForSecondsRealtime(2);

        questionMenu.SetActive(false);
        resumeTimerScreen.SetActive(true);
        timerText.text = "Resume in: 3";
        yield return new WaitForSecondsRealtime(1);
        timerText.text = "Resume in: 2";
        yield return new WaitForSecondsRealtime(1);
        timerText.text = "Resume in: 1";
        yield return new WaitForSecondsRealtime(1);
        scoreManager.score -= 50;
        resumeTimerScreen.SetActive(false);
        Time.timeScale = 1;
        scoreManager.StartMinusFifty();
        Debug.Log("Coroutine Finished");
    }
}
