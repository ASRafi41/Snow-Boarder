using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torqueAmount = 30f; // Adjust the torque value as neededs
    [SerializeField] float boostSpeed = 30f; // Speed to apply when boosting
    [SerializeField] float baseSpeed = 20f; // Base speed of the player
    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true; // Flag to control movement

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindFirstObjectByType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    public void DisableMovement()
    {
        canMove = false; // Set the flag to false to disable movement
    }
    void RespondToBoost()
    {
        if(Keyboard.current.upArrowKey.isPressed)
        {
            UnityEngine.Debug.Log("Up arrow key pressed, boosting speed");
            surfaceEffector2D.speed = boostSpeed; // Apply boost speed
        }
        else if(Keyboard.current.downArrowKey.isPressed)
        {
            UnityEngine.Debug.Log("Down arrow key pressed, reducing speed");
            surfaceEffector2D.speed = baseSpeed; // Reset to base speed
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed; // Ensure base speed is applied when no keys are pressed
        }
    }

    void RotatePlayer()
    {
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            UnityEngine.Debug.Log("Left arrow key pressed");
            rb2d.AddTorque(torqueAmount);
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            UnityEngine.Debug.Log("Right arrow key pressed");
            rb2d.AddTorque(-torqueAmount);
        }
    }

}
