using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    void Update()
    {
        if (FindObjectOfType<FlipCycle>().flipped)
            transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
        else
            transform.Translate(Vector2.left * bulletSpeed * Time.deltaTime);

        Destroy(gameObject, 1f);
    }
}
