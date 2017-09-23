using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notebook : MonoBehaviour {

	public bool isClick = false;
	public GameObject notebook;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (isClick == false && gameObject.transform.position.x > 6.5f)
		{
			execute();
			isClick = true;
		}
	}

	private void OnMouseDown()
	{
		isClick = true;
	}

	private void OnMouseUp()
	{
		isClick = false;
	}

	public void execute()
	{
		gameObject.SetActive(false);
		notebook.SetActive(true);
	}
}
