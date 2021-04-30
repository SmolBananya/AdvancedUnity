using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampAnimations : MonoBehaviour
{
	public int LightMode;
	public GameObject LampLight;


	void Update()
	{
		if (LightMode == 0)
		{
			StartCoroutine(AnimateLight());
		}

	}

	IEnumerator AnimateLight()
	{
		LightMode = Random.Range(1, 5);
		if (LightMode == 1)
		{
			LampLight.GetComponent<Animation>().Play("LightAnim1");
		}
		if (LightMode == 2)
		{
			LampLight.GetComponent<Animation>().Play("LightAnim2");
		}
		if (LightMode == 3)
		{
			LampLight.GetComponent<Animation>().Play("LightAnim3");
		}
		if (LightMode == 4)
		{
			LampLight.GetComponent<Animation>().Play("LightAnim4");
		}
		yield return new WaitForSeconds(0.99f);
		LightMode = 0;

	}
}
