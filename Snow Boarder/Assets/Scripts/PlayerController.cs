using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torqueAmount = 1f; // Adjust the torque value as needed
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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
