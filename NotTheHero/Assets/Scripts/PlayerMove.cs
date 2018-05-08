using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	// Use this for initialization
	public float speed = 10f;
	bool facingLeft=false;
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		float moveH = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D>().velocity = new Vector2(moveH*speed, GetComponent<Rigidbody2D>().velocity.y);

		float moveV = Input.GetAxis ("Vertical");
		transform.Translate (Vector3.up * Input.GetAxis ("Vertical") * speed * Time.deltaTime);

		if (moveH > 0 && !facingLeft) {
			Flip ();
		}
		else if(moveH < 0 && facingLeft){
			Flip();
		}

	}

	void Flip(){
		facingLeft = !facingLeft;

		Vector3 theScale = transform.localScale;

		theScale.x *= -1;

		transform.localScale = theScale;
	}
}