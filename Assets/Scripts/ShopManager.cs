using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopManager : MonoBehaviour
{

    public TextMeshProUGUI coinText;

    public GameObject[] selectedTexts;

    public GameObject orangeDroneBuyButton;
    public GameObject blueDroneBuyButton;
    public GameObject goldenDroneBuyButton;

    void Start()
    {
        
    }

    public void DeselectAllDrones()
    {
        for(int i = 0; i < selectedTexts.Length; i++)
        {
            selectedTexts[i].gameObject.SetActive(false);
        }
    }

    public void Update()
    {
        coinText.text = "Coins : " + PlayerPrefs.GetInt("Coins");

        if (PlayerPrefs.GetInt("OrangeDroneBought") == 0)
        {
            orangeDroneBuyButton.SetActive(true);
        }
        if (PlayerPrefs.GetInt("BlueDroneBought") == 0)
        {
            blueDroneBuyButton.SetActive(true);
        }
        if (PlayerPrefs.GetInt("GoldenDroneBought") == 0)
        {
            goldenDroneBuyButton.SetActive(true);
        }


        if (PlayerPrefs.GetInt("OrangeDroneBought") == 1)
        {
            orangeDroneBuyButton.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BlueDroneBought") == 1)
        {
            blueDroneBuyButton.SetActive(false);
        }
        if (PlayerPrefs.GetInt("GoldenDroneBought") == 1)
        {
            goldenDroneBuyButton.SetActive(false);
        }
    }

    

    
}
