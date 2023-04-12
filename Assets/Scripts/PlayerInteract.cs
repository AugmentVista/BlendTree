using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    
    // GameObject that stores current object in range
    GameObject CurrentObject;
    GlobalVariables globalVariables;

    void Start()
    {
        globalVariables = FindObjectOfType<GlobalVariables>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!globalVariables.isTalking && Input.GetKeyDown("space"))
        {
            Interact();
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            CurrentObject = collision.gameObject;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            CurrentObject = null;
        }
    }

    void Interact()
    {
        // activate the current object here
        if (CurrentObject != null)
            CurrentObject.GetComponent<InteractionObject>().Interact();
    }
}