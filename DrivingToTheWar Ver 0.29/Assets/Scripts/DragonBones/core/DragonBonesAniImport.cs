using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones;

public class DragonBonesAniImport : MonoBehaviour {
	public string stk;
	public string tex;
	public string name = "armatureName";

	// Use this for initialization
	void Start () {
		UnityFactory.factory.LoadDragonBonesData(stk);
		UnityFactory.factory.LoadTextureAtlasData(tex);
		var armatureComponent =UnityFactory.factory.BuildArmatureComponent(name); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
