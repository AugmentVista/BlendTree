using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    public enum Types
    {
        nothing, pickup, info, dialogue
    }
    public Types type;

    public string infoText;
    public List<string> dialogue;

    Info info;


    // Start is called before the first frame update
    void Start()
    {
        info = FindObjectOfType<Info>();
    }

    public void Interact()
    {
        switch (type)
        {
            case Types.nothing:
                Nothing();
                break;
            case Types.pickup:
                Pickup();
                break;
            case Types.info:
                Info();
                break;
            case Types.dialogue:
                Dialogue();
                break;
        }
    }

    void Nothing()
    {
        UnityEngine.Debug.Log("Empty");
    }
    void Pickup()
    {
        UnityEngine.Debug.Log("Acquired");
        gameObject.SetActive(false);
    }
    void Info()
    {
        UnityEngine.Debug.Log("Sheep");
        info.SetText(infoText);
    }
    void Dialogue()
    {
        UnityEngine.Debug.Log("Earwig");
    }
}