using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreTextController : MonoBehaviour {
	GameObject scoreText;

	public static int score;
	// Use this for initialization
	void Start () {
		this.scoreText = GameObject.Find ("scoreText");
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "chara") {
		    score += 1;
			this.scoreText.GetComponent<Text> ().text = "" + score;
		}
}

	public static int getscore(){
		return score;
	}
}