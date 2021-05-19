using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public int EnemyHealth = 20;
    public GameObject Enemy;
    public int StatusCheck;
    public AudioSource JumpScare;

    void DamageZombie(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }




    void Update()
    {
        if (EnemyHealth <= 0 && StatusCheck == 0)
        {
            StatusCheck = 2;
            Enemy.GetComponent<Animation>().Stop("Walk");
            Enemy.GetComponent<Animation>().Play("Die");
            JumpScare.Stop();
        }
    }
}