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
	public int wordCount = 30;
	// Use this for initialization

	private void Awake()
	{
		ajust();
		width = dialogs[1].GetComponent<RectTransform>().sizeDelta.x;
	}

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (isShow)
		{
			StartCoroutine(showDialog(new Vector3(15, 0, 0), "叫克里斯托你好，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托你好，我叫克里斯托", 10f));
			isShow = false;
		}
	}

	public void ajust()
	{
		foreach (GameObject d in dialogs)
		{
			d.GetComponent<RectTransform>().sizeDelta = new Vector2(wordCount * 14 + 36, 35);
		}
		text.rectTransform.sizeDelta = new Vector2(wordCount * 14, 177);
	}



	public IEnumerator showDialog(Vector3 position, string words, float time)
	{
		int i = words.Length / wordCount + 1;
		text.text = words;
		dialog.GetComponent<RectTransform>().anchoredPosition3D = position;
		dialogs[0].GetComponent<RectTransform>().anchoredPosition3D =
			new Vector3(dialogs[0].GetComponent<RectTransform>().anchoredPosition3D.x, dialogs[0].GetComponent<RectTransform>().anchoredPosition3D.y + 20, dialogs[0].GetComponent<RectTransform>().anchoredPosition3D.z);

		for (int j = 0; j <= i; j++)
		{
			dialogs[j].SetActive(true);
		}
		dialogs[i].SetActive(true);
		dialogs[i].GetComponent<RectTransform>().sizeDelta = new Vector2((words.Length % wordCount) *14 + 36, 35);


		Vector3 v = dialogs[i].GetComponent<RectTransform>().anchoredPosition3D;
		print(dialogs[i].GetComponent<RectTransform>().anchoredPosition3D.x);
		dialogs[i].GetComponent<RectTransform>().anchoredPosition3D = new Vector3(v.x - (width - dialogs[i].GetComponent<RectTransform>().sizeDelta.x) / 2, v.y, v.z);
		print(dialogs[i].GetComponent<RectTransform>().anchoredPosition3D.x);
		

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
