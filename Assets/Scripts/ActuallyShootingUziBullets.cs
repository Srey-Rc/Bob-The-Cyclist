using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActuallyShootingUziBullets : MonoBehaviour
{
    public GameObject bulletPrefab;
    void Start()
    {
        StartCoroutine(ShootUziBullets());
    }

    IEnumerator ShootUziBullets()
    {
        while (true)
        { 
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.2f);
        }
    }
}
