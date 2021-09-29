using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 move;
    public float speed = 5.0f;

    private Animator animator;
    public Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Input
        //move.x = Input.GetAxisRaw("Horizontal");
        //move.y = Input.GetAxisRaw("Vertical");

        if (joystick.Horizontal >= 0.2f)
        {
            move.x = speed;
        } else if (joystick.Horizontal <= -0.2f)
        {
            move.x = -speed;
        }
        else
        {
            move.x = 0f;
        }
        if (joystick.Vertical >= 0.2f)
        {
            move.y = speed;
        }
        else if (joystick.Vertical <= -0.2f)
        {
            move.y = -speed;
        }
        else
        {
            move.y = 0f;
        }
        animator.SetFloat("Horizontal", move.x);
        animator.SetFloat("Vertical", move.y);
        animator.SetFloat("Speed", move.sqrMagnitude);
    }

    void FixedUpdate()
    {
        // Movement 

        move.Normalize();

        if (Mathf.Abs(move.x) < 1.0f)
        {
            move.x = 0.0f;
        }
        else
        {
            move.y = 0.0f;
        }

        //transform.Translate(move.x * speed * Time.deltaTime, move.y * speed * Time.deltaTime, 0.0f);
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }
}
