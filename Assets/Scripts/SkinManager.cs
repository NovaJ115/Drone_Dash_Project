using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{

    public string droneSkin;
    public Animator droneAnimation;

    public RuntimeAnimatorController defaultAnim;
    public RuntimeAnimatorController orangeAnim;
    public RuntimeAnimatorController blueAnim;
    public RuntimeAnimatorController goldenAnim;

    public void Update()
    {
        droneSkin = PlayerPrefs.GetString("DroneSkin");

        if(droneSkin == "Default")
        {
            droneAnimation.runtimeAnimatorController = defaultAnim;
        }
        if (droneSkin == "Orange")
        {
            droneAnimation.runtimeAnimatorController = orangeAnim;
        }
        if (droneSkin == "Blue")
        {
            droneAnimation.runtimeAnimatorController = blueAnim;
        }
        if (droneSkin == "Golden")
        {
            droneAnimation.runtimeAnimatorController = goldenAnim;
        }
    }

}
