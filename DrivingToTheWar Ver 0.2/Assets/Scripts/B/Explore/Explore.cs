using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explore : MonoBehaviour {

	public static LogManager log;
	public string word;
	// Use this for initialization
	void Start () {
		log = new LogManager();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		log.show(word, 2);
	}
}
