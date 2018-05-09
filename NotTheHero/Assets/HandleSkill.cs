using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleSkill : MonoBehaviour {

	// Use this for initialization
	public Animator anim1;
	public Animator anim2;
	public Animator anim3;

	public GameObject bulletPrefab;
	public Transform bulletSpawn;

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
		if (Input.GetKey (KeyCode.A)) {
			Move ();
		}
		if (Input.GetKey(KeyCode.S)) {
			Move ();
		}
		if (Input.GetKey(KeyCode.D)) {
			Move ();
		}
		if (Input.GetKeyUp (KeyCode.W)) {
			ReturnState ();
		}
		if (Input.GetKeyUp (KeyCode.A)) {
			ReturnState ();
		}
		if (Input.GetKeyUp(KeyCode.S)) {
			ReturnState ();
		}
		if (Input.GetKeyUp(KeyCode.D)) {
			ReturnState ();
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Skill ();
			Fire ();
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

	void Fire()
	{
		// Create the Bullet from the Bullet Prefab
		var bullet = (GameObject)Instantiate (
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 3.0f);
	}
}
