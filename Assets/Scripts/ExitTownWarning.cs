using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTownWarning : MonoBehaviour
{
    bool triggered;
    Info info;

    private void Start()
    {
        info = FindObjectOfType<Info>();
        triggered = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (triggered) return;
        if (other.tag == "Player") info.SetText("You're entering Gnome territory!");
        triggered = true;
    }
}