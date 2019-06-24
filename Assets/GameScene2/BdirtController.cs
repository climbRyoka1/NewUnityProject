using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BdirtController : MonoBehaviour {
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
		mousePointInWorld.y = Mathf.Clamp (mousePointInWorld.y, -0.6f, 0.7f);
		this.transform.position = mousePointInWorld;
	}

}
