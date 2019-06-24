using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getSCORE : MonoBehaviour {
	int resultSCORE;
	// Use this for initialization
	void Start () {
		this.resultSCORE = scoreTextController.getscore ();
		gameObject.GetComponent<Text> ().text = "SCORE " + resultSCORE;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
