using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseTouch : MonoBehaviour {

	public bool ifMouseOver = false;
	public bool ifMouseLeave = false;
	public bool isOn = false;
	public GameObject exit;

	private void OnMouseDown()
	{
		if (!isOn)
		{
			ifMouseOver = true;
			isOn = true;
			exit.SetActive(true);
		}
		else
		{
			ifMouseLeave = true;
			isOn = false;
			exit.SetActive(false);
		}
	}

}
