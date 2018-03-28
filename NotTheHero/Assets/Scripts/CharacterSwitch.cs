using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour {

	// Use this for initialization
	public GameObject character1;
	public GameObject character2;
	public GameObject character3;

	private int activeChar;

	void Start () {
		activeChar = 0;
		character1.SetActive(true);
		character2.SetActive(false);
		character3.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		//if they press Q the active character is switched
		if (Input.GetKeyDown(KeyCode.E)) {
			activeChar++;
			if (activeChar > 2) {
				activeChar = 0;  // makes sure it cycles through your 3 characters
	
			}
			IsActive ();
		}
	}

	private void IsActive ()
	{
		if (activeChar == 0) { //shows only char 1
			character1.SetActive(true);  
			character2.SetActive(false);
			character3.SetActive(false);
		}
		if (activeChar == 1) { //shows only char 2
			character1.SetActive(false);  
			character2.SetActive(true);
			character3.SetActive(false);
		}
		if (activeChar == 2) { //shows only char 3
			character1.SetActive(false);  
			character2.SetActive(false);
			character3.SetActive(true);
		}
	}
}
