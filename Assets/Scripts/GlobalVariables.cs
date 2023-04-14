using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public bool isTalking;
    public bool CollectableStars;
    public bool FLORPunleashed;

    void Start()
    {
        isTalking = false;
        CollectableStars = true;
        FLORPunleashed = true;
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
            FLORPunleashed = false;

            UnityEngine.Debug.Log("No More placeholders");
        }

    }
    //GameObject.FindWithTag("Star");
}