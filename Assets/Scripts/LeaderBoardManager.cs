using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeaderBoardManager : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    void Update()
    {
        highScoreText.text = "" + PlayerPrefs.GetFloat("Highscore");
    }
}
