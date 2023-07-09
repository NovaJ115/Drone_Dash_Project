using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionButtons : MonoBehaviour
{
    public QuestionManager questionManager;
    public bool incorrect;
    public bool correct;
    public void ButtonPressed()
    {
        if(correct)
        {
            questionManager.TheCorrectAnswer();
            StartCoroutine(AnswerCorrect());
        }
        if (incorrect)
        {
            StartCoroutine(AnswerIncorrect());
        }
        
    }

    public IEnumerator AnswerCorrect()
    {
        this.GetComponent<Image>().color = Color.green;
        yield return new WaitForSecondsRealtime(1.99f);
        this.GetComponent<Image>().color = Color.white;
        
    }
    public IEnumerator AnswerIncorrect()
    {
        this.GetComponent<Image>().color = Color.red;


        yield return new WaitForSecondsRealtime(2);
        Time.timeScale = 1;
        this.GetComponent<Image>().color = Color.white;
        questionManager.questionMenu.SetActive(false);
    }

}
