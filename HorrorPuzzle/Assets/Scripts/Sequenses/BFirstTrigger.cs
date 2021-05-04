using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BFirstTrigger : MonoBehaviour
{
    public GameObject Player;
    public GameObject TextBox;
    public GameObject TheMarker;
	//public GameObject Camera;
	public GameObject FirstTrigger;


	void OnTriggerEnter() { 
		Player.SetActive(false);
		StartCoroutine(ScenePlayer());
		//Camera.SetActive(false);

	}

	IEnumerator ScenePlayer()
	{
		TextBox.GetComponent<Text>().text = "Is there anything useful in this room?";
		yield return new WaitForSeconds(2.5f);
		TextBox.GetComponent<Text>().text = " ";
		Player.SetActive(true);
		TheMarker.SetActive(true);
		//Camera.SetActive(true);
		FirstTrigger.GetComponent<BoxCollider>().enabled = false;


	}
}
