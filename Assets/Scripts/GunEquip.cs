using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEquip : MonoBehaviour
{
    public GameObject gunEquippedSound;
    int gunIndex;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pistol"))
        {
            gunIndex = 0;
            Destroy(collision.gameObject);
            EquipGun();
        }

        if(collision.gameObject.CompareTag("Uzi"))
        {
            gunIndex = 1;
            Destroy(collision.gameObject);
            EquipGun();
        }
    }

    void EquipGun()
    {
        gunEquippedSound.GetComponent<AudioSource>().Play();
        GameObject cycle = transform.parent.gameObject;
        GameObject bob = cycle.transform.GetChild(0).gameObject;
        bob.transform.GetChild(5).gameObject.SetActive(true);
        bob.transform.GetChild(6).gameObject.SetActive(true);
        GameObject shootingHand = bob.transform.GetChild(6).gameObject;
        for(int i = 0; i < shootingHand.transform.childCount; i++)
        {
            if(i == gunIndex)
                shootingHand.transform.GetChild(gunIndex).gameObject.SetActive(true);
            else
                shootingHand.transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
