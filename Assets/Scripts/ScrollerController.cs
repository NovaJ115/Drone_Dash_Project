using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollerController : MonoBehaviour
{

    public Scroller[] allScrollers;
    public GameObject[] allHazards;

    public int count;
    public void StopScrolling()
    {
        for(int i = 0; i < allScrollers.Length; i++)
        {
            allScrollers[i].speed = 0;
        }
        var allTheHazards = FindObjectsOfType<MovementController>();
        for (int i = 0; i < allTheHazards.Length; i++)
        {
            allTheHazards[i].speed = 0;
        }
    }

    public void Update()
    {
        var allTheHazards = FindObjectsOfType<MovementController>();
    }

}
