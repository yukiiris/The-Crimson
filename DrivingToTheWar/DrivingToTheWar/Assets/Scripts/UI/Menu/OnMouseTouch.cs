using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseTouch : MonoBehaviour {

	public bool ifMouseOver = false;
	public bool ifMouseLeave = false;
	public bool isOn = false;

	private void OnMouseDown()
	{
		if (!isOn)
		{
			ifMouseOver = true;
			isOn = true;
		}
		else
		{
			ifMouseLeave = true;
			isOn = false;
		}
	}

}
