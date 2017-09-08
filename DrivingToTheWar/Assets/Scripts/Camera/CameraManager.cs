using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

	public static float rotateSpeed = 3;
	public static float moveSpeed = 0.2f;
	public static Transform trans;
	public static bool rotateLeft = false;
	public static bool rotateRight = false;
	private static float delta = 0;
	public static bool moveRight = false;
	public static bool moveLeft = false;
	// Use this for initialization

	private void Awake()
	{
		trans = GameObject.FindGameObjectWithTag("MainCamera").transform;
	}

	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (rotateLeft)
		{
			delta += rotateSpeed;
			rotateToLeft();
			if (delta == 90)
			{
				rotateLeft = false;
				delta = 0;
			}
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

	public static void rotateToLeft()
	{
		float y = trans.eulerAngles.y;
		trans.eulerAngles = new Vector3(0, y - rotateSpeed, 0);
	}

	public static void rotateToRight()
	{
		float y = trans.eulerAngles.y;
		trans.eulerAngles = new Vector3(0, y + rotateSpeed, 0);
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
