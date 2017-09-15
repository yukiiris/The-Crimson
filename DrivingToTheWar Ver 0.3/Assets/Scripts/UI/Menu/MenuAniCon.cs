﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones;

public class MenuAniCon : MonoBehaviour {

	public bool ifOpen=false;
	public bool ifClose=false;
	private UnityArmatureComponent uac;
	private OnMouseTouch omt;
	private GameObject audioController;

	// Use this for initialization
	void Start () {
		uac = GetComponent<UnityArmatureComponent> ();
		omt = GetComponentInParent<OnMouseTouch> ();
		audioController = GameObject.Find("Audio Controller");
		audioController.SetActive(false);
	}

	void Update () {
		ifOpen = omt.ifMouseOver;
		ifClose = omt.ifMouseLeave;

		if (ifOpen == true) {
			uac.animation.Play ("openmenu", 1);
			audioController.SetActive(true);
			omt.ifMouseOver = false;
		}
		if (ifClose == true && uac.animation.isPlaying == false) {
			uac.animation.Play ("closemenu", 1);
			omt.ifMouseLeave = false;
			audioController.SetActive(false);
		}
	}
}
