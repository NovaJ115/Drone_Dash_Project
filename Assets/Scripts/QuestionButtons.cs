using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionButtons : MonoBehaviour
{
    public QuestionCountdown questionCountdown;
    public void ButtonPress()
    {
        Time.timeScale = 1;
        questionCountdown.questionMenu.SetActive(false);
        questionCountdown.timeAmount = questionCountdown.time;
    }

}
