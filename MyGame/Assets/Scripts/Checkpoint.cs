using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
   public GameObject uiObject;

   void Start()
   {
      uiObject.SetActive(false);
   }

   private void OnTriggerEnter(Collider other)
   {

      if (other.TryGetComponent<Player>(out Player player))
      {
         Debug.Log("Checkpoint");
            
         uiObject.SetActive(true);
         CarDrive.instance.Stop();
         
      }
      
   }
   
   

 
}
