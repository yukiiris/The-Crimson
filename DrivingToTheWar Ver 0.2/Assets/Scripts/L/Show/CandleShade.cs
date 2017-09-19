using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones;
public class CandleShade : MonoBehaviour {
	private UnityArmatureComponent uac;
	private ChangeAlpha ca;


	// Use this for initialization
	void Start () {
		uac = GetComponent<UnityArmatureComponent> ();
		ca = transform.GetChild (1).GetComponent<ChangeAlpha> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (uac.animation.isPlaying) {
			ca.changeAlpha ();
		}
	}
}
