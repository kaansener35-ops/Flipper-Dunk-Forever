using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI scoreText;
    
    public void AddScore()
    {
        score = score + 1;
        Debug.Log(score);
        scoreText.text = "SCORE: " + score;
    }
    
    
}
