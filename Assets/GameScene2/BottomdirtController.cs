using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BottomdirtController : MonoBehaviour{
	void OnMouseDrag()
	{
		Vector3 objectPointInScreen
		= Camera.main.WorldToScreenPoint(this.transform.position);

		Vector3 mousePointInScreen
		= new Vector3(objectPointInScreen.x,
			Input.mousePosition.y,
			objectPointInScreen.z);

		Vector3 mousePointInWorld = transform.position;
		mousePointInWorld.y = Camera.main.ScreenToWorldPoint (Input.mousePosition).y;
		mousePointInWorld.y = Mathf.Clamp (mousePointInWorld.y,-3.8f, -2.6f);
		this.transform.position = mousePointInWorld;
	}

}
