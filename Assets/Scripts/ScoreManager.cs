using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject hoopR;
    public GameObject hoopL;
    public bool chaosMode;
    public int chaosThreshold;
    void Start()
    {
        hoopR.SetActive(true);
        hoopL.SetActive(false);
        chaosThreshold = Random.Range(1, 2);
    }
    public void AddScore()
    {
        score = score + 1;
        scoreText.text = "SCORE: " + score;

        if (hoopR.activeSelf)
        {
            hoopR.SetActive(false);
            hoopL.SetActive(true);
        }
        else
        {
            hoopL.SetActive(false);
            hoopR.SetActive(true);
        }
        if (score >= chaosThreshold)
        {
            chaosMode = true;
            
        }
      
    }
    
    
}
