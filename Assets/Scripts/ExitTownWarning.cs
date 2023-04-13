using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExitTownWarning : MonoBehaviour
{
        bool WithinTown = true;
        public GameObject Town; 
  

    // Update is called once per frame
    void Update()
    {
        void OnTriggerExit2D(Collider2D TownExit)
        {
            WithinTown = false;
        }
        if (!WithinTown)
        {
            GameObject.FindObjectOfType<TownExit>
        }
    }
}
