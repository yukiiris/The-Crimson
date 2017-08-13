using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseTouch : MonoBehaviour {

	public bool ifMouseOver = false;
	public bool ifMouseLeave = false;

	void OnMouseEnter () {
		ifMouseOver = true;
		ifMouseLeave = false;
	}

	void OnMouseExit () {
		ifMouseLeave = true;
		ifMouseOver = false;
	}
}
