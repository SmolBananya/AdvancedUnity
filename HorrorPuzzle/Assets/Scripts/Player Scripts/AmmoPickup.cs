using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public GameObject Ammo;
    public GameObject ammoDisplayBox;

    void OnTriggerEnter(Collider other)
    {
        ammoDisplayBox.SetActive(true);
        GlobalAmmo.ammoCount += 10;
        Ammo.SetActive(false);
    }
}
