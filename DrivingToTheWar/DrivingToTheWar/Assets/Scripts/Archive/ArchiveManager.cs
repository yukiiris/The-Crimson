using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using System.IO;
using UnityEngine;

public class ArchiveManager : MonoBehaviour {

	private void Awake()
	{
		print(11);
		save();
	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public static void save()
	{
		byte[] byData = new byte[200];
		char[] charData = new char[200];

		try
		{
			FileStream aFile = new FileStream("ArchiveManager.cs", FileMode.Open);
			aFile.Seek(135, SeekOrigin.Begin);
			aFile.Read(byData, 0, 200);
		}
		catch (IOException e)
		{
			print("An IO exception has been thrown!");
			print(e.ToString());
	
			return;
		}

		Decoder d = Encoding.UTF8.GetDecoder();
		d.GetChars(byData, 0, byData.Length, charData, 0);

		print(charData);

	}
}
