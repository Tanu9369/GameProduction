using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleSkill : MonoBehaviour {

	// Use this for initialization
	public Animator anim1;
	public Animator anim2;
	public Animator anim3;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetInput ();

	}

	void GetInput(){
		if (Input.GetKey(KeyCode.W)) {
			Move ();
		}
		else if (Input.GetKey (KeyCode.A)) {
			Move ();
		}
		else if (Input.GetKey(KeyCode.S)) {
			Move ();
		}
		else if (Input.GetKey(KeyCode.D)) {
			Move ();
		}
		else if (Input.GetKeyUp (KeyCode.W)) {
			ReturnState ();
		}
		else if (Input.GetKeyUp (KeyCode.A)) {
			ReturnState ();
		}
		else if (Input.GetKeyUp(KeyCode.S)) {
			ReturnState ();
		}
		else if (Input.GetKeyUp(KeyCode.D)) {
			ReturnState ();
		}
		else if (Input.GetKeyDown (KeyCode.Space)) {
			Skill ();
		}
	}

	void Move(){
		anim1.SetInteger ("State", 1);
		anim2.SetInteger ("State", 1);
		anim3.SetInteger ("State", 1);

		return;
	}

	void ReturnState(){
		anim1.SetInteger ("State", 0);
		anim2.SetInteger ("State", 0);
		anim3.SetInteger ("State", 0);
		return;
	}
	void Skill(){
		anim1.SetTrigger ("skill");
		anim2.SetTrigger ("skill");
		anim3.SetTrigger ("skill");
		return;
	}
		
}
