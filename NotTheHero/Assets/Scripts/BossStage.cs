using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStage : MonoBehaviour {
	
	// Use this for initialization
	public bool dead = false;
	public GameObject boss;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this == null) {
			Instantiate (boss, transform.position, Quaternion.identity);
		}
	}

}
