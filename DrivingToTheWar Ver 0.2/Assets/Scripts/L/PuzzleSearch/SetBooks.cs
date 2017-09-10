using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetBooks : MonoBehaviour {
	public GameObject textParent;
	public GameObject bookParent;
	private Text text;
	private GameObject book;
	private Vector3 bookPos = new Vector3(0,0,0);
	private Vector3 textPos = new Vector3 (800, 400, 0);
	private int[] randomNum = new int[10];
	public GameObject[] books = new GameObject[14];
	public Text[] texts = new Text[14];
	private float textY = 400f;

	void Start () {
		//随机数生成
		int i = 1;
		int m = 0;
		bool ifagain = false;
		randomNum [0] = Random.Range (0, 14);

		while (i < 10) {
			randomNum [i] = Random.Range (0, 14);
			while (m < i) {
				if (randomNum [m] == randomNum [i]) {
					ifagain = true;
				}
				++m;
			}
			if (ifagain == false) {
				++i;
			} else {
				ifagain = false;
			}
			m = 0;
		}

		i = 0;

		//放置内容
		while(i<10){
			//文字
			text = Instantiate (texts [randomNum [i]]);
			text.transform.parent = textParent.transform;
			textPos.y = textY;
			textY = textY - 50f;
			text.transform.localPosition = textPos;

			//shu
			book = Instantiate (books [randomNum [i]]);
			bookPos = book.transform.localPosition;
			book.transform.parent = bookParent.transform; 
			book.transform.localPosition = bookPos;
			book.GetComponent<SearchPoint> ().text = text;
			book.GetComponent<SearchPoint> ().manager = bookParent.transform.GetChild (0).gameObject;
			i++;
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
