using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHARAgenerator : MonoBehaviour {
	public GameObject redPREFAB;


	private int max = scoreTextController.getscore ();
	// Use this for initialization
	void Start () {
		for (int i = 0; i < max; i++) {
			GameObject red = Instantiate (redPREFAB)as GameObject;
			red.transform.position = new Vector2 (Random.Range (-6, 6), 10);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
