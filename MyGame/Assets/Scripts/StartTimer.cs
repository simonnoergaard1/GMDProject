using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            Debug.Log("Checkpoint");
            
            TimerController.instance.BeginTimer();
        }
    }
}
