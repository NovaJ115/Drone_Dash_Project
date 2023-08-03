using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionButtons : MonoBehaviour
{
    public QuestionManager questionManager;
    //public bool incorrect;
    public bool correct;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;

    public void Start()
    {
        button1.GetComponent<QuestionButtons>().correct = false;
        button1.GetComponent<QuestionButtons>().correct = false;
        button1.GetComponent<QuestionButtons>().correct = false;
        button1.GetComponent<QuestionButtons>().correct = false;
    }

    public void ButtonPressed()
    {
        if(correct)
        {
            questionManager.TheCorrectAnswer();
            StartCoroutine(AnswerCorrect());
            button1.GetComponent<Button>().enabled = false;
            button2.GetComponent<Button>().enabled = false;
            button3.GetComponent<Button>().enabled = false;
            button4.GetComponent<Button>().enabled = false;
        }
        if (!correct)
        {
            questionManager.TheIncorrectAnswer();
            StartCoroutine(AnswerIncorrect());
            button1.GetComponent<Button>().enabled = false;
            button2.GetComponent<Button>().enabled = false;
            button3.GetComponent<Button>().enabled = false;
            button4.GetComponent<Button>().enabled = false;
        }
        
    }

    public IEnumerator AnswerCorrect()
    {
        this.GetComponent<Image>().color = Color.green;
        yield return new WaitForSecondsRealtime(1.95f);
        this.GetComponent<Image>().color = Color.white;
        
    }
    public IEnumerator AnswerIncorrect()
    {
        this.GetComponent<Image>().color = Color.red;
        yield return new WaitForSecondsRealtime(1.95f);
        this.GetComponent<Image>().color = Color.white;
    }


    public void Update()
    {
        if(questionManager.theQuestions[questionManager.currentQuestion].GetComponent<Question>().option1Correct == true)
        {
            button1.GetComponent<QuestionButtons>().correct = true;
        }
        if (questionManager.theQuestions[questionManager.currentQuestion].GetComponent<Question>().option2Correct == true)
        {
            button2.GetComponent<QuestionButtons>().correct = true;
        }
        if (questionManager.theQuestions[questionManager.currentQuestion].GetComponent<Question>().option3Correct == true)
        {
            button3.GetComponent<QuestionButtons>().correct = true;
        }
        if (questionManager.theQuestions[questionManager.currentQuestion].GetComponent<Question>().option4Correct == true)
        {
            button4.GetComponent<QuestionButtons>().correct = true;
        }

    }

    

}
