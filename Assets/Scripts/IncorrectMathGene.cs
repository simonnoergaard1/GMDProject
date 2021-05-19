using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncorrectMathGene : MonoBehaviour
{

    public Text textButton2;
    
    // Start is called before the first frame update
    void Start()
    {
        multiplyQuestion();
    }

    int multiplyQuestion()
    {
        int number1 = Mathf.FloorToInt(Random.value * 50);
        int number2 = Random.Range(2, 10);
        textButton2.text = number1 + " * " + number2 + " = " + (number1 * number2 + Random.Range(2, 10));
        return (number1 * number2);
    }
}
