using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionButtons : MonoBehaviour
{
    public QuestionManager questionManager;
    public void ButtonPress()
    {
        Time.timeScale = 1;
        questionManager.questionMenu.SetActive(false);
        
    }

}
