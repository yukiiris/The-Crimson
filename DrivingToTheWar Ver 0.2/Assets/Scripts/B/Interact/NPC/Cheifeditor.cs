using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheifeditor : MonoBehaviour {

	public Dialog manager;
	// Use this for initialization
	void Start () {
		manager = GameObject.Find("DialogManager").GetComponent<Dialog>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		manager.show("你好世界", new Vector3(15, 0, 0));
	}
}
