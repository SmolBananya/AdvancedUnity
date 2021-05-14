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
        yield return new WaitForSeconds(0.2f);
        isAttacking = false;
    }








}
