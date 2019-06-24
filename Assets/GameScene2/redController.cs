using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class redController : MonoBehaviour {

	Animator animator;
	Rigidbody2D rigid2D;
	AudioSource audioSource;
	public AudioClip clip1;


	private float speed = 1f;
	private float deadLine = -6;

	private int dScore = 0;

	// Use this for initialization
	void Start () {
		this.animator = GetComponent<Animator> ();
		this.rigid2D = GetComponent<Rigidbody2D> ();
		this.audioSource = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (this.speed* Time.deltaTime, 0, 0);
		if (transform.position.y < this.deadLine) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D (Collision2D other){ 
		
		if (other.gameObject.tag == "blue"|| other.gameObject.tag == "green") {
			this.audioSource.PlayOneShot (clip1);
			this.audioSource.PlayDelayed (1.5f);
			this.gameObject.transform.Rotate (0, 0, 90);
			this.speed = 0f;
			Invoke ("bomb", 1.5f);
			Invoke ("Destroy", 2f);
		}


		if (other.gameObject.tag == "Wall" || other.gameObject.tag == "red") {
			this.gameObject.transform.Rotate (0, 180, 0);

		}
			
		if (other.gameObject.tag == "Ground") {
			this.animator.SetBool ("isGround", true);

		} 
	}

	 void Destroy(){
		Destroy (gameObject);

	}

	void bomb(){
		this.animator.SetBool ("death", true);
	}
		

}
