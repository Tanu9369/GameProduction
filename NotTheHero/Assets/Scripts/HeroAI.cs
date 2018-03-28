using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAI : MonoBehaviour {

	// Use this for initialization
	public float speed;
	public Transform target;
	public float chaseRange;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Chase the player
		//Get distance to target and chase if close enough
		float distanceTarget = Vector3.Distance (transform.position, target.position);
		if (distanceTarget < chaseRange) {
			//start chasing - turn + move towards the target
			Vector3 targetDir = target.position - transform.position;//target pos
			float z = Mathf.Atan2 (targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;//angle
			Quaternion q = Quaternion.AngleAxis (z, Vector3.forward);//current face direction
			transform.rotation = Quaternion.RotateTowards (transform.rotation, q, 180);//start rotation

			transform.Translate (Vector3.up * Time.deltaTime * speed);//move
		}

	}
}
