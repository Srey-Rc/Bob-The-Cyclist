using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleMovement : MonoBehaviour
{
    float inputx;
    public float tiltSpeed, jumpVelocity;
    public int jumpCount;
    Rigidbody2D rgbd;
    private void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        inputx = Input.GetAxisRaw("Horizontal");
        rgbd.MoveRotation(rgbd.rotation - inputx * tiltSpeed * Time.fixedDeltaTime); // tilting the cycle
    }

    private void Update()
    {
        //jumping
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
        {
            jumpCount++;
            rgbd.velocity = new Vector2(rgbd.velocity.x, jumpVelocity);         
        }
    }
}
