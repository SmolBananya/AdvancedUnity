using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public GameObject Ammo;

    void OnTriggerEnter(Collider other)
    {
        Ammo.SetActive(false);
    }
}
