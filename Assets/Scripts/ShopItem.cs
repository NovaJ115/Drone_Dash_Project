using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItem : MonoBehaviour
{
    
    public int itemCost;
    private int currentCoins;
    public bool orangeDrone;
    public bool blueDrone;
    public bool goldenDrone;

    public AudioSource itemLocked;
    public AudioSource itemUnlocked;

    public void BuyItem()
    {
        if (orangeDrone)
        {
            if (PlayerPrefs.GetInt("Coins") < itemCost)
            {
                itemLocked.Play();
            }
            if (PlayerPrefs.GetInt("Coins") >= itemCost)
            {
                
                PlayerPrefs.SetInt("OrangeDroneBought", 1);
                itemUnlocked.Play();
                PlayerPrefs.SetInt("Coins", currentCoins - itemCost);
            }
            
        }
        if (blueDrone)
        {
            if (PlayerPrefs.GetInt("Coins") < itemCost)
            {
                itemLocked.Play();
            }
            if (PlayerPrefs.GetInt("Coins") >= itemCost)
            {
                
                PlayerPrefs.SetInt("BlueDroneBought", 1);
                itemUnlocked.Play();
                PlayerPrefs.SetInt("Coins", currentCoins - itemCost);
            }
            
        }
        if (goldenDrone)
        {
            if (PlayerPrefs.GetInt("Coins") < itemCost)
            {
                itemLocked.Play();
            }
            if (PlayerPrefs.GetInt("Coins") >= itemCost)
            {
                
                PlayerPrefs.SetInt("GoldenDroneBought", 1);
                itemUnlocked.Play();
                PlayerPrefs.SetInt("Coins", currentCoins - itemCost);
            }
            
        }
        
    }

    public void Update()
    {
        currentCoins = PlayerPrefs.GetInt("Coins");
    }

}
