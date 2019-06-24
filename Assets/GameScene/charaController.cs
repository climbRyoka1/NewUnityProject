using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charaController : MonoBehaviour {
	 
	Animator animator;
	Rigidbody2D rigid2D;
	AudioSource audioSource;
	public AudioClip clip1;

	private float jumpvelocity = 7;
	private float movevelocity = 1.76f;
	private float speed = 10f;
	private float deadLine = -6;
	private float GoalLine = 12;



	private bool isGrounded;
	private bool isGoal;


	// Use this for initialization
	void Start () {
		this.animator = GetComponent<Animator> ();
		this.rigid2D = GetComponent<Rigidbody2D> ();
		this.audioSource = GetComponent<AudioSource> ();
	}


	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > this.GoalLine) {
			Destroy (gameObject);

		}
		if (transform.position.y < this.deadLine) {
			Destroy (gameObject);

		}
	}

	void OnTriggerEnter2D (Collider2D other){
		
		if (other.gameObject.tag == "Start"|| other.gameObject.tag == "Grass") {
			this.rigid2D.velocity = new Vector2 (this.movevelocity, this.jumpvelocity);
			this.animator.SetTrigger ("isGrounded");
			audioSource.PlayOneShot (clip1);
		}

		if (other.gameObject.tag == "Goal") {
			this.gameObject.transform.Translate (this.speed * Time.deltaTime, 0, 0);
			this.animator.SetBool ("isGoal",true);
			Debug.Log (Time.deltaTime);
		}



	}

	void Destroy(){
		Destroy (gameObject);
	}
}
