using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    public GameObject cycleBody;
    Rigidbody2D rgbd;
    public float rotationSpeed;

    private void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && cycleBody.GetComponent<FlipCycle>().flipped==false)
            rgbd.MoveRotation(rgbd.rotation - rotationSpeed * Time.fixedDeltaTime);
        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && cycleBody.GetComponent<FlipCycle>().flipped==true)
            rgbd.MoveRotation(rgbd.rotation + rotationSpeed * Time.fixedDeltaTime);
    }
}
