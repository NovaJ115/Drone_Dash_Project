using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Question : MonoBehaviour
{
    [TextArea(1,3)]
    public string question;
    [TextArea(1, 3)]
    public string option1;
    [TextArea(1, 3)]
    public string option2;
    [TextArea(1, 3)]
    public string option3;
    [TextArea(1, 3)]
    public string option4;

    public bool option1Correct;
    public bool option2Correct;
    public bool option3Correct;
    public bool option4Correct;
}
