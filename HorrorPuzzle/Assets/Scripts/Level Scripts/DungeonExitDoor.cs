using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DungeonExitDoor : MonoBehaviour
{
    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
   // public GameObject Door;
   // public AudioSource CreakSound;
	public GameObject Crosshair;
	public GameObject ExtraCross;
	public GameObject FadeOut;

    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;
    }

	void OnMouseOver()
	{
		if (Distance <= 2)
		{
            ExtraCross.SetActive(true);
			ActionText.GetComponent<Text>().text = "Open door";
            Crosshair.SetActive(false);
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
				FadeOut.SetActive(true);
				StartCoroutine(FadeToExit());
				//Door.GetComponent<Animation>().Play("FirstDoorOpenAnim");
				//CreakSound.Play();
			}
		}
	}

	void OnMouseExit()
	{
		ActionDisplay.SetActive(false);
		ActionText.SetActive(false);
        ExtraCross.SetActive(false);
        Crosshair.SetActive(true);
	}

	IEnumerator FadeToExit()
    {
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene(5);

	}



}
