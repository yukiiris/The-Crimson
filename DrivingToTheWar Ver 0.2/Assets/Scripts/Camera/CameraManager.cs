using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraManager : MonoBehaviour {

	public static float rotateSpeed = 3;
	public static float moveSpeed = 0.2f;
	public static Transform trans;
	public static bool rotateLeft = false;
	public static bool rotateRight = false;
	private static float delta = 0;
	public static bool moveRight = false;
	public static bool moveLeft = false;
	static public GameObject toUnload;
	static public GameObject toLoad;
	static public string Sub;
	static public float delayTime;
	static bool isChanging = false;
	public GameObject black;
	// Use this for initialization

	private void Awake()
	{
		trans = GameObject.FindGameObjectWithTag("MainCamera").transform;
	}

	void Start()
	{

	}

	public static void change(GameObject toLoad, GameObject toUnload)
	{
		CameraManager.toLoad = toLoad;
		CameraManager.toUnload = toUnload;
	}

	// Update is called once per frame
	void Update()
	{
		if (rotateLeft)
		{
			black.SetActive(true);
			StartCoroutine(ch());
			rotateLeft = false;
		}
		if (rotateRight)
		{
			delta += rotateSpeed;
			rotateToRight();
			if (delta == 90)
			{
				rotateRight = false;
				delta = 0;
			}
		}
		if (moveLeft)
		{
			delta += moveSpeed;
			moveToLeft();
			if (delta - 3 > 0.05)
			{
				moveLeft = false;
				delta = 0;
			}
		}
		if (moveRight)
		{
			delta += moveSpeed;
			moveToRight();
			if (delta - 3 >0.05f)
			{
				moveRight = false;
				delta = 0;
			}
		}

	}
	IEnumerator ch()
	{
		//Vector3 temp = Player.current.GetComponentInParent<Leg>().transform.position;
		//black.transform.position = (Vector2)Camera.main.transform.position;
		Fade.FadeIn(black);
		yield return new WaitForSeconds(0.5f);
		toUnload.SetActive(false);
		toLoad.SetActive(true);
		//SubtitleSystem.ShowSpecialSubtitle(Sub, delayTime);
		//yield return new WaitForSeconds(delayTime);
		//SceneManager.LoadScene(toLoad, LoadSceneMode.Additive);
		//Player.current.GetComponentInParent<Leg>().transform.position = temp;
		Fade.Disappear(black);
		isChanging = false;
		//Fade.FadeOut(black);
		//SceneManager.UnloadSceneAsync("过渡场景");
	}


	public static void rotateToLeft()
	{
		float y = trans.eulerAngles.y;
		trans.eulerAngles = new Vector3(0, -90, 0);
	}

	public static void rotateToRight()
	{
		float y = trans.eulerAngles.y;
		trans.eulerAngles = new Vector3(0, 90, 0);
	}

	public static void moveToRight()
	{
		trans.position = new Vector3(trans.position.x + moveSpeed, trans.position.y, trans.position.z);
	}

	public static void moveToLeft()
	{
		trans.position = new Vector3(trans.position.x - moveSpeed, trans.position.y, trans.position.z);
	}

	public static void moveTo(int x)
	{

	}
}
