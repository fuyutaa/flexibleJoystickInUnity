using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public MovementJoystick movementJoystick;
    public float moveSpeed;
    private Rigidbody2D rb;
    public Vector3 m_velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(movementJoystick.joystickVec.y != 0)
        {
            Vector3 targetVelocity = new Vector2(movementJoystick.joystickVec.x * moveSpeed,movementJoystick.joystickVec.y * moveSpeed);
            rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref m_velocity, .05f);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}