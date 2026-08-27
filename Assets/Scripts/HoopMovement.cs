using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopMovement : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 startScale;
    private bool isMoving = false;
    private bool isScaling = false;
    public float minY = 2f;
    public float maxY = 5f;

   public void StartMoving()
    {
        isMoving = true;
    }
    public void StartScaling()
    {
        isScaling = true;
    }
    void Awake()
    {
        startScale = transform.localScale;

    }
    void Update()
    {
        if(isMoving)
        {
            transform.position = startPosition + Vector3.up * Mathf.Sin(Time.time) * 2;
        }
        if(isScaling)
        {
            transform.localScale = startScale * (0.65f + Mathf.Sin(Time.time) * 0.20f);
        }
    }
    void OnEnable()
{
    float randomY = Random.Range(minY, maxY);
    Vector3 newPos = new Vector3(transform.position.x, randomY, transform.position.z);
    transform.position = newPos;
    startPosition = newPos;
    isMoving = false; 
    isScaling = false;
    transform.localScale = startScale;
    ScoreManager manager = FindObjectOfType<ScoreManager>();
    if(manager.chaosMode)
    {
    if(Random.value < 0.8f)
    {
        isMoving = true;
    }
    if(Random.value < 0.7f)
    {
        isScaling = true;
    }
}
}
}