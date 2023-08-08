using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSelectionManager : MonoBehaviour
{
    public GameObject selectedText;

    public ShopManager shopManager;

    public bool defaultDrone;
    public bool orangeDrone;
    public bool blueDrone;
    public bool goldenDrone;

    public bool defaultDroneSkin;
    public bool orangeDroneSkin;
    public bool blueDroneSkin;
    public bool goldenDroneSkin;

    public string theActiveSkin;
    public string droneSkin;

    
    public void SetTextActive()
    {
        shopManager.DeselectAllDrones();
        selectedText.SetActive(true);
        if(defaultDrone == true)
        {
            AllBoolsFalse();
            defaultDroneSkin = true;
        }
        if (orangeDrone == true)
        {
            AllBoolsFalse();
            orangeDroneSkin = true;
        }
        if (blueDrone == true)
        {
            AllBoolsFalse();
            blueDroneSkin = true;
        }
        if (goldenDrone == true)
        {
            AllBoolsFalse();
            goldenDroneSkin = true;
        }
        if (defaultDroneSkin == true)
        {
            PlayerPrefs.SetString("DroneSkin", "Default");
        }
        if (orangeDroneSkin == true)
        {
            PlayerPrefs.SetString("DroneSkin", "Orange");
        }
        if (blueDroneSkin == true)
        {
            PlayerPrefs.SetString("DroneSkin", "Blue");
        }
        if (goldenDroneSkin == true)
        {
            PlayerPrefs.SetString("DroneSkin", "Golden");
        }


        
    }

    public void Update()
    {
        theActiveSkin = PlayerPrefs.GetString("DroneSkin");

        
        Debug.Log(theActiveSkin);
    }

    public void AllBoolsFalse()
    {
        defaultDrone = false;
        orangeDrone = false;
        blueDrone = false;
        goldenDrone = false;
    }

}
