using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Dialog : MonoBehaviour {

	public GameObject dialog;
	public  GameObject[] dialogs = new GameObject[6];
	public  Text text;
	public float width;
	public bool isShow = true;
	// Use this for initialization

	private void Awake()
	{
		width = dialogs[0].GetComponent<RectTransform>().sizeDelta.x;
		print(width);
	}

	void Start () {
		//StartCoroutine(showDialog(new Vector3(10, 0, 0), "，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托", 2.2f));
		//StartCoroutine(showDialog(new Vector3(10, 0, 0), "你好，我叫克里斯托", 2.2f));
	}
	
	// Update is called once per frame
	void Update () {
		if (isShow)
		{
			StartCoroutine(showDialog(new Vector3(10, 0, 0), "叫克里斯托你好，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托", 2.2f));
			isShow = false;
		}
	}

	public void ajust()
	{
		foreach (GameObject d in GameObject.FindGameObjectsWithTag("dialog"))
		{
			
		}
	}



	public IEnumerator showDialog(Vector3 position, string words, float time)
	{
		int i = words.Length / 16 + 1;
		text.text = words;
		dialog.GetComponent<RectTransform>().anchoredPosition3D = position;
		dialogs[0].GetComponent<RectTransform>().anchoredPosition3D =
			new Vector3(dialogs[0].GetComponent<RectTransform>().anchoredPosition3D.x, dialogs[0].GetComponent<RectTransform>().anchoredPosition3D.y + 20, dialogs[0].GetComponent<RectTransform>().anchoredPosition3D.z);
		Debug.Log(words);
		for (int j = 0; j <= i; j++)
		{
			dialogs[j].SetActive(true);
		}
		dialogs[i].SetActive(true);
		dialogs[i].GetComponent<RectTransform>().sizeDelta = new Vector2((words.Length % 16) *14 + 36, 35);

		yield return new WaitForSeconds(time);
		for (int j = 0; j <= i; j++)
		{
			dialogs[j].SetActive(false);
		}
		text.text = "";
	}

	public IEnumerator f()
	{
		int t = 2;
		yield return 0;
		showDialog(new Vector3(10, 0, 0), "你好，我是克里斯托，来自中国", 2.2f);
		yield return new WaitForSeconds(t);
		Debug.Log(t);
		for (int j = 0; j <= 5; j++)
		{
			dialogs[j].SetActive(false);
		}
		text.text = "";
	}
	private static int getMax(string[] word)
	{
		int length = word[0].Length;
		foreach (string s in word)
		{
			length = length > s.Length ? length : s.Length;
		}
		return length;
	}


}
