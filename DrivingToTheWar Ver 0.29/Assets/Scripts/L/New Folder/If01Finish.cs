using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If01Finish : MonoBehaviour {

	public GameObject item;
	public bool ifEnd = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (EventButton.buttons [0] && item.transform.childCount == 2) {
			GetComponents<Explore> () [0].enabled = false;
			GetComponents<Explore> () [1].enabled = false;
			GetComponent<ChangeWords> ().enabled = false;
			ifEnd = true;
		}
	}

	void OnMouseDown(){
		if (ifEnd) {
			transform.GetChild (0).gameObject.SetActive (true);
			GetComponent<C_01Finish> ().enabled = true;
			this.enabled = false;
		}
	}


}
