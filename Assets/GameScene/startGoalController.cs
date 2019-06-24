using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGoalController : MonoBehaviour {
    Rigidbody2D rb;
	Vector2 defaultpos;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		defaultpos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 pos = new Vector2 (defaultpos.x, defaultpos.y + Mathf.PingPong (Time.time, 7));
		rb.MovePosition (pos);
	}
}
