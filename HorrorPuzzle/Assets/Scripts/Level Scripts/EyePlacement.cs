using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyePlacement : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject EyePieces;
    public GameObject ExtraCross;
	public GameObject eyeLight;
	public GameObject RisingWall;



	void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

	void OnMouseOver()
	{
		if (GlobalInventory.leftEye == true && GlobalInventory.rightEye == true)
		{



			if (TheDistance <= 2)
			{
				ExtraCross.SetActive(true);
				ActionText.GetComponent<Text>().text = "Place eye pieces";
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
					EyePieces.SetActive(true);
					RisingWall.GetComponent<Animator>().Play("WallRise");

				}
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
