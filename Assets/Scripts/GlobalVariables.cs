using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public bool isTalking;
    public bool CollectableStars;
    public bool BLORPunleashed;

    void Start()
    {
        isTalking = false;
        CollectableStars = false;
        BLORPunleashed = false;
    }

    void Update()
    {
        if (!GameObject.FindWithTag("Star")) 
        {
            CollectableStars = true;

            //Debug.Log("No More stars");
        }
        if (!GameObject.FindWithTag("GNOME"))
        {
            BLORPunleashed = true;

            //Debug.Log("No More gnomes");
        }

    }
    //GameObject.FindWithTag("Star");
}