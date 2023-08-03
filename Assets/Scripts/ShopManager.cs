using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopManager : MonoBehaviour
{

    public TextMeshProUGUI coinText;

    public GameObject[] selectedTexts;



    void Start()
    {
        coinText.text = "Coins : " + PlayerPrefs.GetInt("Coins");
    }

    public void DeselectAllDrones()
    {
        for(int i = 0; i < selectedTexts.Length; i++)
        {
            selectedTexts[i].gameObject.SetActive(false);
        }


        
    }
   
}
