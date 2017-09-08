using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour {

	public GameObject toLoad;
	public GameObject toUnload;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		CameraManager.rotateLeft = true;
		CameraManager.change(toLoad, toUnload);
	}
}
