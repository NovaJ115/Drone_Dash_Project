using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetHighScore : MonoBehaviour
{

    public void ResetTheHighScore()
    {
        PlayerPrefs.SetFloat("Highscore", 0);
    }

}
