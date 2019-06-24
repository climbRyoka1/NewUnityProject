using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getscore : MonoBehaviour {
	private int getpoint;
	// Use this for initialization
	void Start () {
		this.getpoint = beansscore.getsScore ();
		gameObject.GetComponent<Text> ().text = "SCORE " + getpoint;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
