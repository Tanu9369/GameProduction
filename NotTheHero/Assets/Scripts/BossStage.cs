﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossStage : MonoBehaviour {
	
	// Use this for initialization
	public GameObject blood;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			Instantiate (blood, transform.position, Quaternion.identity);
			Destroy (gameObject);
			Application.LoadLevel ("Win Screen");
		}

	}
}
