using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventButton : MonoBehaviour {

	public static bool[] buttons = { true, true, true, true };
	// Use this for initialization
	private void Awake()
	{
		for (int i = 0; i < 5; i++)
		{
			//buttons[i] = false;
		}
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
