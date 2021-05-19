using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CorrectMathGene : MonoBehaviour
{

    public Text textButton;

    private void Start()
    {
        multiplyQuestion();
    }

    int multiplyQuestion()
    {
        int number1 = Mathf.FloorToInt(Random.value * 50);
        int number2 = Random.Range(2, 10);
        textButton.text = number1 + " * " + number2 + " = " + number1 * number2;
        return (number1 * number2);
    }
}
