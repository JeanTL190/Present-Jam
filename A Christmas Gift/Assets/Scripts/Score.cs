using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text highScoreText;
    private string textScore, textHigh;
    void Start()
    {
        textScore = "Score: ";
        textHigh = "High Score: ";
        scoreText.text = textScore + score.ToString();
        highScoreText.text = textHigh + PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    public void Pontua(int pontos)
    {
        score += pontos;
    }
    void Update()
    {
        if(score> PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = textHigh + score.ToString();
        }
        scoreText.text = textScore + score.ToString();
    }
}
