using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundGenerator : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		

		this.gameObject.transform.position = new Vector2 (transform.position.x, Random.Range(-4,2));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
