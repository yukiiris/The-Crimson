﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyOfCar : MonoBehaviour {

	public GameObject key;
	public GameObject game;
	public static bool flag = false;
	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		if (flag)
		{
			key.SetActive(true);
			game.SetActive(false);
		}
	}
}