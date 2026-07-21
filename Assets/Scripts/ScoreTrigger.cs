using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball") && other.GetComponent<Rigidbody2D>().velocity.y < 0)
        
        {
           ScoreManager manager = FindObjectOfType<ScoreManager>();
            manager.AddScore();
        }
    }
    
}
