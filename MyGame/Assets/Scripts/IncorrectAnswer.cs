using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncorrectAnswer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Text question;
    

    public void ButtonClicked()
    {
        question.text = "Wrong answer!";




    }
}
