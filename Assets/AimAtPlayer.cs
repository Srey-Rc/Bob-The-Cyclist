using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimAtPlayer : MonoBehaviour
{
    public GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z + 60);
    }
    void Update()
    {
        Vector2 direction = new Vector2(player.transform.position.x - transform.position.x,
            player.transform.position.y - transform.position.y);

        transform.up = direction * -1;
    }
}
