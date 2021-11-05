using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootUziBullets : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float timebetweenShots, newShootTime;
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.timeSinceLevelLoad > newShootTime)
            {
                Instantiate(bulletPrefab, transform.position, transform.rotation);
                newShootTime = Time.timeSinceLevelLoad + timebetweenShots;
            }
        }
    }
}
