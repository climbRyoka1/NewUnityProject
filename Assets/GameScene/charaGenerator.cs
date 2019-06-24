using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charaGenerator : MonoBehaviour {
	
	public GameObject charaprefab;

	private float delta = 0;
	private float span = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		this.delta += Time.deltaTime;
		if (this.delta > this.span) {
			this.delta = 0;
			GameObject chara = Instantiate (charaprefab) as GameObject;
			chara.transform.position = new Vector2 (-6.6f, 8);
			this.span = Random.Range (1, 5);
		}
	}
}
