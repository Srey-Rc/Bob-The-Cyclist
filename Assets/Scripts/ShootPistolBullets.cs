using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPistolBullets : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float timebetweenShots, newShootTime;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.timeSinceLevelLoad > newShootTime)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            newShootTime = Time.timeSinceLevelLoad + timebetweenShots;
        }
    }
}
