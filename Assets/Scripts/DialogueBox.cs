using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class DialogueBox : MonoBehaviour
{
    TMP_Text ScreenText;
    UnityEngine.UI.Image BackgroundPanel;
    Queue<string> TextQueue = new Queue<string>();
    GlobalVariables globalVariables;
    InteractionObject CurrentObject;


    // Start is called before the first frame update
    void Start()
    {
        ScreenText = GetComponentInChildren<TMP_Text>();
        BackgroundPanel = GetComponentInChildren<UnityEngine.UI.Image>();
        globalVariables = FindObjectOfType<GlobalVariables>();
        BackgroundPanel.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (globalVariables.isTalking && Input.GetKeyDown("e"))
        {
            NextLine();
        }
    }

    public void SecondQueue(List<string> SecondDialogue)
    {
        TextQueue.Clear();
        foreach (string SecondDialogueItem in SecondDialogue)
        {
            TextQueue.Enqueue(SecondDialogueItem);
        }
        BackgroundPanel.enabled = true;
        NextLine();
    }
    // if i set a condition that turns off isTalking on the pickup of an item then i can set a new bool to play the second text




    public void FillQueue(List<string> dialogue, InteractionObject interactionObj)
    {
        CurrentObject = interactionObj;
        TextQueue.Clear();

        if (globalVariables.BLORPunleashed)
        {
            CurrentObject.ThirdToFirst();
        }
        else if (globalVariables.CollectableStars)
        {
            CurrentObject.SecondToFirst();
        }

        foreach (string dialogueItem in dialogue)
        {
            TextQueue.Enqueue(dialogueItem);
        }
        BackgroundPanel.enabled = true;
        globalVariables.isTalking = true;
        NextLine();
    }




    
    void NextLine()
    {
        if (TextQueue.Count > 0)
        {
            ScreenText.text = TextQueue.Dequeue();
        }
        else if (TextQueue.Count == 0)
        {
            ScreenText.text = "";
            globalVariables.isTalking = false;
            BackgroundPanel.enabled = false;
        }
    }
}    


    




