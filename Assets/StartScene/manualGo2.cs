using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manualGo2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClickbutton(){
		SceneManager.LoadScene ("GameScene2 copy");
		Time.timeScale = 1f;
	}
}
