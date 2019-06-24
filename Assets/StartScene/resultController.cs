using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultController : MonoBehaviour {

	GameObject result;
	GameObject result2;

	int resultScore;
	int resultScore2;
	// Use this for initialization
	void Start () {
		this.result = GameObject.Find ("result");
		this.result2 = GameObject.Find ("result 2");
		this.resultScore = beansscore.getsScore();
		this.resultScore2 = scoreTextController.getscore ();
		this.result.GetComponent<Text> ().text = "SCORE " + resultScore;
		this.result2.GetComponent<Text> ().text = "SCORE " + resultScore2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
