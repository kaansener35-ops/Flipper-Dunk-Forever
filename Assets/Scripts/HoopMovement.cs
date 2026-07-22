using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopMovement : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 startScale;
    private bool isMoving = false;
    private bool isScaling = false;

   public void StartMoving()
    {
        isMoving = true;
    }
    public void StartScaling()
    {
        isScaling = true;
    }
    void Start()
    {
        startPosition = transform.position;
        startScale = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving)
        {
            transform.position = startPosition + Vector3.up * Mathf.Sin(Time.time) * 2;
        }
        if(isScaling)
        {
            transform.localScale = startScale * (0.65f + Mathf.Sin(Time.time) * 0.35f);
        }
        
    }
}
