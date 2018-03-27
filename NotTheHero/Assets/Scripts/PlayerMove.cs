using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones;
public class PlayerMove : MonoBehaviour {

	// Use this for initialization
	public float speed;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * Input.GetAxis ("Horizontal") * speed * Time.deltaTime);
		transform.Translate (Vector3.up * Input.GetAxis ("Vertical") * speed * Time.deltaTime);
        UnityArmatureComponent armatureComponent = GetComponent<UnityArmatureComponent>();
        armatureComponent.animation.FadeIn("Walk", 0.25f, -1);
    }
    
    
}
