using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;
    public float EnemySpeed = 0.01f;
    public bool AttackTrigger = false;
    public bool isAttacking = false;
    public AudioSource hurtSound1;
    public AudioSource hurtSound2;
    public AudioSource hurtSound3;
    public int hurtGen;

    void Update()
    {
        transform.LookAt(Player.transform);

        if(AttackTrigger == false)
        {
            EnemySpeed = 0.01f;
            Enemy.GetComponent<Animation>().Play("Walk");
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, EnemySpeed);
        }

        if(AttackTrigger == true && isAttacking == false)
        {
            EnemySpeed = 0;
            Enemy.GetComponent<Animation>().Play("Attack");
            StartCoroutine(InflictDamage());
        }
    }

    void OnTriggerEnter()
    {
        AttackTrigger = true;
    }

    void OnTriggerExit()
    {
        AttackTrigger = false;
    }

    IEnumerator InflictDamage()
    {
        isAttacking = true;
        yield return new WaitForSeconds(1.5f);
        GlobalHealth.currentHealth -= 5;
        hurtGen = Random.Range(1, 4);

        if(hurtGen == 1)
        {
            hurtSound1.Play();
        }
        if (hurtGen == 2)
        {
            hurtSound2.Play();
        }
        if (hurtGen == 3)
        {
            hurtSound3.Play();
        }

        yield return new WaitForSeconds(0.2f);
        isAttacking = false;
    }








}
