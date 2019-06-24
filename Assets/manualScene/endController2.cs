using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endController2 : MonoBehaviour {
	public GameObject Timer;

	private float time = 30;
	// Use this for initialization
	void Start () {
		this.Timer = GameObject.Find ("Time");
		this.Timer.GetComponent<Text>().text =((int)time).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		this.time -= Time.deltaTime;
		if (this.time < 0) {
			SceneManager.LoadScene ("StartScene");
		}
		this.Timer.GetComponent<Text> ().text = ((int)time).ToString();
	}
}
