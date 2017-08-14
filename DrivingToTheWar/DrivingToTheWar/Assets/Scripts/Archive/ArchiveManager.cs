using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using System.IO;
using UnityEngine;

public class ArchiveManager : MonoBehaviour {

	public static string path;

	private void Awake()
	{
		save();
	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void load()
	{
		byte[] byData = new byte[1024];
		char[] charData = new char[1024];

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

		Decoder d = Encoding.UTF8.GetDecoder();
		string myStr = System.Text.Encoding.UTF8.GetString(byData);
		print(myStr);
	}

	public static void save()
	{
		byte[] byData;
		char[] charData;

		try
		{
			FileStream aFile = new FileStream(path, FileMode.Create);
			charData = "My pink half of the drainpipe.".ToCharArray();
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
