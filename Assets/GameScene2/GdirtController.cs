using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GdirtController : MonoBehaviour {
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
		mousePointInWorld.y = Mathf.Clamp (mousePointInWorld.y, -3f, -1.8f);
		this.transform.position = mousePointInWorld;
	}

}
