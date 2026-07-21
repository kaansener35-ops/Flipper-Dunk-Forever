using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopMovement : MonoBehaviour
{
    private Vector3 startPosition;
    private bool isMoving = false;

   public void StartMoving()
    {
        isMoving = true;
    }
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving)
        {
            transform.position = startPosition + Vector3.up * Mathf.Sin(Time.time) * 2;
        }
        
    }
}
