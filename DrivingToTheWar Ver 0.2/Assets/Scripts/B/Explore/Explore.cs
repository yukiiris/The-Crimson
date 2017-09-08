using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explore : MonoBehaviour {

	public LogManager manager;
	public string word;
	public float time;
	// Use this for initialization
	void Start () {
		manager = GameObject.Find("LogManager").GetComponent<LogManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		manager.show(word, time);
	}
}
