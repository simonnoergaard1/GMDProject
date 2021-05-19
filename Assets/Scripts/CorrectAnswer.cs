using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorrectAnswer : MonoBehaviour
{
    public GameObject question;
    

    public void ButtonClicked()
    {
        
        question.SetActive(false);
        CarDrive.instance.Restart();
        

    }
    
}
