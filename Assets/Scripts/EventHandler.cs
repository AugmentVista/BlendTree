using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    GameObject BLORP;
    GlobalVariables globalVariables;

    void Start()
    {
        globalVariables = FindObjectOfType<GlobalVariables>();
        BLORP = GameObject.Find("BLORP");
        BLORP.SetActive(false);
    }

    void Update()
    {
        if (globalVariables.CollectableStars) BLORP.SetActive(true);
    }
}