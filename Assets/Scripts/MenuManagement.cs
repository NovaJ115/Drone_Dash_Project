using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagement : MonoBehaviour
{

    public void Reset()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainScene");

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
    }

}
