using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour {

	public int useNum;
	public bool ifUse = false;

	void OnTriggerStay(Collider item){
		print(111);
		if (item.gameObject.GetComponent<ItemInfo> ().itemNum == useNum) {
			Destroy (item.gameObject);
			ifUse = true;
			item.gameObject.GetComponent<ItemCommon> ().ifUse = true;
		}
	}

}
