using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public bool isTalking;
    public bool SpokenTo;
    public bool CollectableStars;

    void Start()
    {
        isTalking = false;
        SpokenTo = false;
        CollectableStars = true;
        
    }

    void Update()
    {
        if (!GameObject.FindWithTag("Star")) 
       {
           CollectableStars=false;

            UnityEngine.Debug.Log("No More stars");

       }

    }
    //GameObject.FindWithTag("Star");
}