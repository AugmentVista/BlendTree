using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public bool isTalking;
    public bool SpokenTo;
    public bool CollectableStars;
    public bool CollectablePlaceholder;

    void Start()
    {
        isTalking = false;
        SpokenTo = false;
        CollectableStars = true;
        CollectablePlaceholder = true;
    }

    void Update()
    {
        if (!GameObject.FindWithTag("Star")) 
        {
            CollectableStars = false;

            UnityEngine.Debug.Log("No More stars");
        }
        if (!GameObject.FindWithTag("PlaceHolder"))
        {
            CollectablePlaceholder = false;

            UnityEngine.Debug.Log("No More placeholders");
        }

    }
    //GameObject.FindWithTag("Star");
}