using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public bool cloud;
    public bool tree;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cloud == true)
        {
            gameObject.transform.Translate(-.06f, 0, 0);
        }
        
        if(tree == true)
        {
            gameObject.transform.Translate(-.08f, 0, 0);
        }

    }
}
