using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    public GameObject questionMenu;

    public void OpenQuestionMenu()
    {
        questionMenu.SetActive(true);
        Time.timeScale = 0;
    }


}
