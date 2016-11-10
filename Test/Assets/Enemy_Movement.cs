using UnityEngine;
using System.Collections;

public class Enemy_Movement : MonoBehaviour {

	int count;
	int rand;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		count++;
		if (count % 10 == 0) {
			randomize ();
		}
		movement ();
	}

	void OnCollisionEnter2D(Collision2D other){
		Destroy (gameObject);
	}

	void randomize () {
		rand = (int) (Random.value * 4 + 1);
	}

	void movement () {
		if (rand == 1) {
			transform.Translate (.2f, 0, 0);
		} else if (rand == 2) {
			transform.Translate (0, .2f, 0);
		} else if (rand == 3) {
			transform.Translate (-.2f, 0, 0);
		} else if (rand == 4) {
			transform.Translate (0, -.2f, 0);
		}
	}
}