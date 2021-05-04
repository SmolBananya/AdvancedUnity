using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opening : MonoBehaviour
{
	public GameObject Player;
	public GameObject FadeScreenIn;
	public GameObject TextBox;
	public GameObject Camera;


	void Start()
	{
		//ThePlayer.GetComponent<FirstPersonAIO>().enabled = false;
		Player.SetActive(false);
		StartCoroutine(ScenePlayer());
	}

	IEnumerator ScenePlayer()
	{
		yield return new WaitForSeconds(1.5f);
		FadeScreenIn.SetActive(false);
		TextBox.GetComponent<Text>().text = "Where am I?";
		yield return new WaitForSeconds(2);
		TextBox.GetComponent<Text>().text = " ";
		yield return new WaitForSeconds(1);
		TextBox.GetComponent<Text>().text = "I must get out of here.";
		yield return new WaitForSeconds(2);
		TextBox.GetComponent<Text>().text = " ";
		Player.SetActive(true);
		//ThePlayer.GetComponent<FirstPersonController>().enabled = true;
		Camera.SetActive(false);
	}
}
