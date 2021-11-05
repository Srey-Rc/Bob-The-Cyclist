using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlipCycle : MonoBehaviour
{
    public bool flipped;
    public int keypressCount=0;
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) 
        { 
            keypressCount++;
            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
            if (keypressCount % 2 == 1)
                flipped = true;
            else
                flipped = false;
        }
    }
}
