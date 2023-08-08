using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public GameObject questionMenu;

    public TextMeshProUGUI questionText;
    public TextMeshProUGUI option1Text;
    public TextMeshProUGUI option2Text;
    public TextMeshProUGUI option3Text;
    public TextMeshProUGUI option4Text;

    public GameObject resumeTimerScreen;
    public TextMeshProUGUI timerText;
    public float timeAmount;

    public bool countdownActive;

    public float time;

    public GameObject[] theQuestions;

    public ScoreManager scoreManager;

    public int currentQuestion;

    public QuestionButtons questionButtons;

    public AudioSource correctSound;
    public AudioSource incorrectSound;
    public AudioSource timerClick;

    public DroneCollider droneCollider;

    public void Start()
    {
        countdownActive = false;
        time = timeAmount;
    }
    public void OpenQuestionMenu()
    {
        droneCollider.droneFlyingSound.Stop();
        ResetButtons();
        questionMenu.SetActive(true);
        currentQuestion = Random.Range(0, theQuestions.Length);
        questionText.text = theQuestions[currentQuestion].GetComponent<Question>().question;
        option1Text.text = theQuestions[currentQuestion].GetComponent<Question>().option1;
        option2Text.text = theQuestions[currentQuestion].GetComponent<Question>().option2;
        option3Text.text = theQuestions[currentQuestion].GetComponent<Question>().option3;
        option4Text.text = theQuestions[currentQuestion].GetComponent<Question>().option4;
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
        
        correctSound.Play();
        yield return new WaitForSecondsRealtime(2);
        
        questionMenu.SetActive(false);
        resumeTimerScreen.SetActive(true);
        timerText.text = "Resume in: 3";
        timerClick.Play();
        yield return new WaitForSecondsRealtime(1);
        timerClick.Play();
        timerText.text = "Resume in: 2";
        yield return new WaitForSecondsRealtime(1);
        timerClick.Play();
        timerText.text = "Resume in: 1";
        yield return new WaitForSecondsRealtime(1);
        scoreManager.score += 150;
        scoreManager.coinAmount += 3;
        resumeTimerScreen.SetActive(false);
        Time.timeScale = 1;
        scoreManager.StartOneHundredFifty();
        droneCollider.droneFlyingSound.Play();
        Debug.Log("Coroutine Finished");
    }

    public IEnumerator IncorrectAnswer()
    {
        incorrectSound.Play();
        yield return new WaitForSecondsRealtime(2);

        questionMenu.SetActive(false);
        resumeTimerScreen.SetActive(true);
        timerText.text = "Resume in: 3";
        timerClick.Play();
        yield return new WaitForSecondsRealtime(1);
        timerClick.Play();
        timerText.text = "Resume in: 2";
        yield return new WaitForSecondsRealtime(1);
        timerClick.Play();
        timerText.text = "Resume in: 1";
        yield return new WaitForSecondsRealtime(1);
        scoreManager.score -= 50;
        resumeTimerScreen.SetActive(false);
        Time.timeScale = 1;
        scoreManager.StartMinusFifty();
        droneCollider.droneFlyingSound.Play();
        Debug.Log("Coroutine Finished");
    }

    public void ResetButtons()
    {
        questionButtons.button1.GetComponent<Button>().enabled = true;
        questionButtons.button2.GetComponent<Button>().enabled = true;
        questionButtons.button3.GetComponent<Button>().enabled = true;
        questionButtons.button4.GetComponent<Button>().enabled = true;
    }
}
