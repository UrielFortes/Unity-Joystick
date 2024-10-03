using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JoystickController;


public class playerController : MonoBehaviour
{
    private Joystick controller;
    private Rigidbody2D rb;
    public float speed;


    void Start()
    {
        controller = FindObjectOfType(typeof(Joystick)) as Joystick;
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float h = controller.Horizontal();
        float v = controller.Vertical();

        rb.velocity = new Vector2(h * speed, v * speed);
    }
}
