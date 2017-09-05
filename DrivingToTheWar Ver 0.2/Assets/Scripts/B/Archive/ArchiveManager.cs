using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using System.IO;
using UnityEngine;

public class ArchiveManager : MonoBehaviour {

	public static string path = "save.txt";
	public static int time = 0;
	public static int scene = 0;
	public static Transform itemBlock;


	private void Awake()
	{
		itemBlock = GameObject.Find("Item").transform;
	}
	// Use this for initialization
	void Start () {
		load();
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
		GameObject parent = GameObject.Find("Item");
		string file = System.Text.Encoding.UTF8.GetString(byData);
		string[] items = file.Split(',');
		foreach (string item in items)
		{
			string[] iteminfo = item.Split(' ');
			GameObject g = (GameObject)Resources.Load("C:\\Users\\asus\\Documents\\GitHub\\The-Crimson\\DrivingToTheWar Ver 0.2\\Assets\\Prefabs\\block");
			g.transform.position = new Vector3(float.Parse(iteminfo[1]), float.Parse(iteminfo[2]), -1);
			g.transform.parent = parent.transform;
		}
	}

	public static char[] buildFile()
	{
		string file = null;
		//file += time.ToString() + ",";
		//file += scene.ToString() + ",";
		foreach (Transform g in itemBlock)
		{
			file += g.name + " ";
			file += g.GetComponent<ItemCommon>().myX + " ";
			file += g.GetComponent<ItemCommon>().myY + ",";
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
