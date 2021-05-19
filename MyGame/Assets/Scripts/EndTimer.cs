using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndTimer : MonoBehaviour
{

    public Text myTime;

    


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            Debug.Log("Checkpoint");

            TimerController.instance.EndTimer();

            CarDrive.instance.Stop();
            

            //myTime.text = "Your time was: " + PlayerPrefs.GetString("savedtime") + " Well Done!";

            AudioListener.pause = true;



            SceneManager.LoadScene("MainMenu");


        }
    }

}
