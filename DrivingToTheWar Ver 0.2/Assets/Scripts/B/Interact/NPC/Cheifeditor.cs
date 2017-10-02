using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheifeditor : MonoBehaviour {

	public Dialog manager;
	int[] words = { 0, 0, 0, 0 };
	// Use this for initialization
	void Start () {
		manager = GameObject.Find("DialogManager").GetComponent<Dialog>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		if (!EventButton.buttons[2])
		{
			if (words[0] == 0)
			{
				manager.show("去帮我把铅字架收拾好，然后来我这拿通行证。", new Vector3(-400, 100, 0));
				words[0]++;
			}
			else if (words[0] == 1)
			{
				manager.show("收拾完了吗？", new Vector3(-400, 100, 0));
				words[0] = 0;
			}
		}
	
		if (!EventButton.buttons[1] && EventButton.buttons[2] && !EventButton.buttons[3])
		{
			if (words[1] == 0)
			{
				manager.show("既然申请到了去前线采访的任务，那就好好干。这是批下来的通行证，拿去把你的信息印上去吧。", new Vector3(-400, 100, 0));
				words[1]++;
			}
			else if (words[1] == 1)
			{
				manager.show("这种拙劣的玩笑并不有趣，小姐。请快点去印刷台印好你的信息。", new Vector3(-400, 100, 0));
				words[1] = 0;
			}

		}
		if (!EventButton.buttons[1] && EventButton.buttons[2] && EventButton.buttons[3])
		{
			if (words[1] == 0)
			{
				manager.show("士兵们在前线全力拼杀、为国争光。而你，还在到处找那倒霉车钥匙。", new Vector3(-400, 100, 0));
			}
		}
		if (!EventButton.buttons[0] && EventButton.buttons[1] && EventButton.buttons[2])
		{
			manager.show("你的记者证带上了吗？小姐。", new Vector3(-400, 100, 0));
			return;
		}
		if (EventButton.buttons[1] && EventButton.buttons[2] && EventButton.buttons[3])
		{

			if (words[2] == 0)
			{
				manager.show("如何鼓舞我们英勇的战士，如何安抚他们伟大的亲属？这是你时刻应该考虑的问题。……出发吧。谨记你的职责。", new Vector3(-400, 100, 0));
				words[2]++;
			}
			else if(words[2] == 1)
			{
				manager.show("还在这干什么？可以出发了。", new Vector3(-400, 100, 0));
				words[2] = 0;
			}
		}
	}
}
