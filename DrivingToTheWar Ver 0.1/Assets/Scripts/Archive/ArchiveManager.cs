﻿using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using System.IO;
using UnityEngine;

public class ArchiveManager : MonoBehaviour {

	public static string path = "save.txt";
	public static int time = 0;
	public static int scene = 0;
	public static Transform item;


	private void Awake()
	{
		item = GameObject.Find("GameObject").transform;
	}
	// Use this for initialization
	void Start () {
		save();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void load()
	{
		byte[] byData = new byte[1024];

		try
		{
			FileStream aFile = new FileStream(path, FileMode.Open);
			aFile.Read(byData, 0, 200);
		}
		catch (IOException e)
		{
			print("An IO exception has been thrown!");
			print(e.ToString());

			return;
		}
		string myStr = System.Text.Encoding.UTF8.GetString(byData);
		print(myStr);
	}

	public static char[] buildFile()
	{
		string file = null;
		file += time.ToString() + ",";
		file += scene.ToString() + ",";
		foreach (Transform g in item)
		{
			file += g.name + ",";
		}
		return file.ToCharArray();
	}

	public static void save()
	{
		byte[] byData;
		char[] charData = buildFile();

		try
		{
			FileStream aFile = new FileStream(path, FileMode.Create);
			byData = new byte[charData.Length];
			Encoder e = Encoding.UTF8.GetEncoder();
			e.GetBytes(charData, 0, charData.Length, byData, 0, true);

			// Move file pointer to beginning of file.
			aFile.Seek(0, SeekOrigin.Begin);
			aFile.Write(byData, 0, byData.Length);
		}
		catch (IOException ex)
		{
			Console.WriteLine("An IO exception has been thrown!");
			Console.WriteLine(ex.ToString());
			return;
		}
	}
}
