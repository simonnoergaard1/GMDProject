using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public TextMeshProUGUI score;


    public void Awake()
    {
        LoadScore();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game closed!");
    }

    public void LoadScore()
    {
        score.text = PlayerPrefs.GetString("savedtime");
    }

}
