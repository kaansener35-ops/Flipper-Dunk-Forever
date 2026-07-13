using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FlipperController : MonoBehaviour

{
    private HingeJoint2D flipperJoint;
    void Start()
    {
        flipperJoint = GetComponent<HingeJoint2D>();
    }

    void Update()
    { 
        if (Input.GetMouseButton(0))
        {
            JointMotor2D motor = flipperJoint.motor;
            motor.motorSpeed = 650;
            flipperJoint.motor = motor;
        }
        
        else 
        
        { 
            JointMotor2D motor = flipperJoint.motor;
            motor.motorSpeed = -350;
            flipperJoint.motor = motor;
            }
    }

}
