using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightEyePickUp : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject RightEye;
    public GameObject ExtraCross;
	public GameObject eyeLight;


	void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

	void OnMouseOver()
	{
		if (TheDistance <= 2)
		{
			ExtraCross.SetActive(true);
			ActionText.GetComponent<Text>().text = "Pick up an eye part";
			ActionDisplay.SetActive(true);
			ActionText.SetActive(true);
		}
		if (Input.GetButtonDown("Action"))
		{
			if (TheDistance <= 2)
			{
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				ExtraCross.SetActive(false);
				eyeLight.SetActive(false);
				RightEye.SetActive(false);
				GlobalInventory.firstDoorKey = true;
			}
		}
	}

	void OnMouseExit()
	{
		ExtraCross.SetActive(false);
		ActionDisplay.SetActive(false);
		ActionText.SetActive(false);
	}

}
