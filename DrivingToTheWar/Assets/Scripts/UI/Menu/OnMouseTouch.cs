using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseTouch : MonoBehaviour {

	public bool ifMouseOver = false;
	public bool ifMouseLeave = false;

	void OnMouseEnter () {
		ifMouseOver = true;
	}

	void OnMouseExit () {
		ifMouseLeave = true;
	}
}
