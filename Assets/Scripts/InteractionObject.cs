using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    public enum Types
    {
        nothing, pickup, info, dialogue, 
    }
    public Types type;

    public string infoText;
    public List<string> dialogue;
    public List<string> SecondDialogue;
    public int ItemsCollected;
    Info info;
    DialogueBox dialogueBox;

  

    // Start is called before the first frame update
    void Start()
    {
        info = FindObjectOfType<Info>();
        dialogueBox = FindObjectOfType<DialogueBox>();
 
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
       
        gameObject.SetActive(false);

    }
    void Info()
    {
        UnityEngine.Debug.Log("Info Display");
        info.SetText(infoText);
    }
    void Dialogue()
    {
        UnityEngine.Debug.Log("Dialogue registering");
        dialogueBox.FillQueue(dialogue);
    }

    public void SecondToFirst()
    {
        dialogue.Clear();
        foreach (string line in SecondDialogue)
        {
            dialogue.Add(line);
        }
    }
}