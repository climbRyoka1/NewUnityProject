using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class groundController2 : MonoBehaviour
{
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
		mousePointInWorld.y = Mathf.Clamp (mousePointInWorld.y, -4.0f, 2.0f);
		this.transform.position = mousePointInWorld;
	}
}