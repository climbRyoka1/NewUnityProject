using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retryBUTTON : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClickRetryButton(){
		SceneManager.LoadScene("GameScene");
		Time.timeScale = 1f;
	}
}
