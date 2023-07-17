using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopManager : MonoBehaviour
{

    public TextMeshProUGUI coinText;

    void Start()
    {
        coinText.text = "Coins : " + PlayerPrefs.GetInt("Coins");
    }

   
}
