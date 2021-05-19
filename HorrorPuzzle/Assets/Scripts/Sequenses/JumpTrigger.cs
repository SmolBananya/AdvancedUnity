using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    public AudioSource DoorBang;
    public AudioSource DoorJumpMusic;
    public GameObject Zombie;
    public GameObject Door;
    public GameObject Lamp;


    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        Door.GetComponent<Animation>().Play("JumpDoorAnim");
        DoorBang.Play();
        Zombie.SetActive(true);
        Lamp.SetActive(true);
        StartCoroutine(PlayJumpMusic());
    }

    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(0.4f);
        DoorJumpMusic.Play();
    }
}