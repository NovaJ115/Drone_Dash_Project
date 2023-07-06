using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public bool bird;
    public bool tree;
    public float birdSpeed;
    public float treeSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bird == true)
        {
            gameObject.transform.Translate(birdSpeed * Time.deltaTime, 0, 0);
        }
        
        if(tree == true)
        {
            gameObject.transform.Translate(treeSpeed * Time.deltaTime, 0, 0);
        }

    }
}
