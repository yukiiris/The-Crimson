using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour {
	public int rightNum = 0;
	public int winNum = 0;
	public bool ifPuzzleWin = false;

	void Update () {
		if (rightNum == winNum) {
			ifPuzzleWin = true;
		}
	}
}
