using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class beansscore : MonoBehaviour {

	GameObject survivor;



	public static int sScore ;


	// Use this for initialization
	void Start () {
		sScore = 0;
		this.survivor = GameObject.Find ("survivor");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "red") {
			sScore += 1;
			this.survivor.GetComponent<Text> ().text = "SCORE " + sScore;
	}
}

	public static int getsScore (){
		return sScore;
	}
}