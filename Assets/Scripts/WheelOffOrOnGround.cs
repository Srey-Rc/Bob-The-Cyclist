using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelOffOrOnGround : MonoBehaviour
{
    public bool grounded = true;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
            transform.GetComponentInParent<CycleMovement>().jumpCount = 0;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            grounded = false;
    }
}
