using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour {
	
	public GameObject Timer;
	public GameObject finish;


	private float time = 60;
	// Use this for initialization
	void Start () {
		this.Timer = GameObject.Find ("Time");
		this.finish = GameObject.Find ("finish");

		this.finish.SetActive (false);

		this.Timer.GetComponent<Text> ().text = ((int)this.time).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		this.time -= Time.deltaTime;
		if (this.time < 0) {
			this.finish.SetActive (true);
			time = 0;
			Invoke ("GoResult", 3f);

		}
		this.Timer.GetComponent<Text> ().text = ((int)time).ToString();
	}

	void GoResult(){
		SceneManager.LoadScene ("resultScene2");
	}
}
