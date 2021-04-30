using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject Door;
    public AudioSource CreakSound;

    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;
    }

	void OnMouseOver()
	{
		if (Distance <= 2)
		{
			ActionDisplay.SetActive(true);
			ActionText.SetActive(true);
		}
		if (Input.GetButtonDown("Action"))
		{
			if (Distance <= 2)
			{
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				Door.GetComponent<Animation>().Play("FirstDoorOpenAnim");
				CreakSound.Play();
			}
		}
	}

	void OnMouseExit()
	{
		ActionDisplay.SetActive(false);
		ActionText.SetActive(false);
	}




}
