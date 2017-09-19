using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones;

public class MouseOverAni : MonoBehaviour {

	private UnityArmatureComponent uac;
	private string aniName;

	// Use this for initialization
	void Start () {
		uac = GetComponent<UnityArmatureComponent> ();
		aniName = uac.animation.animationNames [0];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseEnter(){
		uac.animation.Play (aniName,1);
	}


}
