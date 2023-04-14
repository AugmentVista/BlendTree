using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExitTownWarning : MonoBehaviour
{
        bool WithinTown = true;
        public GameObject Town; 
  

    
    void Start()
    {
        void OnTriggerExit2D(Collider2D TownExit)
        {
            WithinTown = false;
        }
       
        
        
        if (!WithinTown)
        {
            Town = GameObject.Find("TownExit");
            Town.SetActive(false);
        }
    }
}
