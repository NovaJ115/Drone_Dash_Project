using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagement : MonoBehaviour
{
    Scene currentScene;

    string sceneName;

    public GameObject shopMenu;
    public void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
    }
    public void Reset()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainScene");

    }

    public void Update()
    {
        if(sceneName == "MainScene")
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Time.timeScale = 1;
                Reset();
            }
        }
        
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainScene");
    }
    public void ReturnToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void OpenShop()
    {
        shopMenu.SetActive(true);
    }
    public void CloseShop()
    {
        shopMenu.SetActive(false);
    }

    public void ResetShop()
    {
        PlayerPrefs.SetInt("OrangeDroneBought", 0);
        PlayerPrefs.SetInt("BlueDroneBought", 0);
        PlayerPrefs.SetInt("GoldenDroneBought", 0);
        PlayerPrefs.SetInt("Coins", 0);
    }

}
