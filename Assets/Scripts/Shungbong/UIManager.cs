using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameoverPanel;

    public void setScoreText(string txt)
    {
        if(scoreText)
        scoreText.text = txt;
    }
    public void showGameoverPanel(bool show)
    {
        if(gameoverPanel)
        gameoverPanel.SetActive(show);
    }
  
}
