using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour {
	public GameObject redpfab;

	private int MAX = beansscore.getsScore ();
	// Use this for initialization
	void Start () {
		for (int i = 0; i < MAX; i++) {
			GameObject redp = Instantiate (redpfab)as GameObject;
			redp.transform.position = new Vector2 (Random.Range (-6, 6), 10);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
