using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class DialogueBox : MonoBehaviour
{
    TMP_Text ScreenText;
    UnityEngine.UI.Image BackgroundPanel;
    Queue<string> TextQueue = new Queue<string>();
    GlobalVariables globalVariables;

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

    public void FillQueue(List<string> dialogue)
    {
        TextQueue.Clear();
        foreach(string dialogueItem in dialogue)
        {
            TextQueue.Enqueue(dialogueItem);
        }
        BackgroundPanel.enabled = true;
        NextLine();
        globalVariables.isTalking = true;
    }
    void NextLine()
    {
        if (TextQueue.Count == 0)
        {
            ScreenText.text = "";
            globalVariables.isTalking = false;
            BackgroundPanel.enabled = false;
            return;
        }

        ScreenText.text = TextQueue.Dequeue();
    }
}