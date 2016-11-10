using UnityEngine;
using System.Collections;

public class Ball_Movement : MonoBehaviour {

	public Rigidbody2D rigid;
	public GameObject bullet;
	public float bulletSpeed;
	public float moveSpeed;
	public bool goodFire;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.DownArrow) 
		         && Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate(new Vector3(-1, -1, 0) * moveSpeed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.DownArrow) 
		         && Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (new Vector3(1,-1,0) * moveSpeed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.UpArrow) 
		         && Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (new Vector3(-1,1,0) * moveSpeed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.UpArrow) 
		         && Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (new Vector3(1,1,0) * moveSpeed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (new Vector3(-1,0,0) * moveSpeed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (new Vector3(1,0,0) * moveSpeed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (new Vector3(0,1,0) * moveSpeed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (new Vector3(0,-1,0) * moveSpeed * Time.deltaTime);
		}
		if (goodFire){
			if (Input.GetKeyDown(KeyCode.Space)){
				InvokeRepeating("fire",0, 1);
			}
			if (Input.GetKeyUp(KeyCode.Space)){
				CancelInvoke("fire");
			}
		}
		else {
			if (Input.GetKeyDown (KeyCode.Space)){
				fire();
			}
		}
	}

	void fire(){
		GameObject b = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
		b.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed*Mathf.Sign(transform.localScale.x), 0);
	}
}

/*
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)){
			rigid.velocity = new Vector2(-1, rigid.velocity.y);
			transform.localScale = new Vector3(-xScale,transform.localScale.y,transform.localScale.z);
		}
		else if (Input.GetKey (KeyCode.RightArrow)){
			rigid.velocity = new Vector2(1, rigid.velocity.y);
			transform.localScale = new Vector3(xScale,transform.localScale.y,transform.localScale.z);
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)){
			rigid.velocity = new Vector2(rigid.velocity.x, jumpHeight);
		}
		if (goodFire){
			if (Input.GetKeyDown(KeyCode.Space)){
				InvokeRepeating("fire",0, 1);
			}
			if (Input.GetKeyUp(KeyCode.Space)){
				CancelInvoke("fire");
			}
		}
		else {
			if (Input.GetKeyDown (KeyCode.Space)){
				fire();
			}
		}
	}
	
	void fire(){
		GameObject b = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
		b.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed*Mathf.Sign(transform.localScale.x), 0);
	}
}
*/
