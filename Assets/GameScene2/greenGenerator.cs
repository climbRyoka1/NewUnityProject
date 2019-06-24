using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenGenerator : MonoBehaviour {

	public GameObject greenprefab;

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
			GameObject chara = Instantiate (greenprefab) as GameObject;
			chara.transform.position = new Vector2 (Random.Range(-2f,2f), -0.6f);
			this.span = Random.Range (4, 7);
		}
	}
}
