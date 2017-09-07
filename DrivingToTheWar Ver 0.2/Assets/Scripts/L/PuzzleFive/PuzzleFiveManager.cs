using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleFiveManager : MonoBehaviour {
	public int rightNum = 0;
	public bool ifFivePuzzleWin = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (rightNum == 9) {
			ifFivePuzzleWin = true;
		}
	}
}
