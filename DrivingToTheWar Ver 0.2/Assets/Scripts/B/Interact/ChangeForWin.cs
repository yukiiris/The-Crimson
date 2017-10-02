using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeForWin : MonoBehaviour {
	public GameObject reporterID;
	public GameObject game;
	public static bool flag = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (flag)
		{
			reporterID.SetActive(true);
			game.SetActive(false);
		}
		}

}
