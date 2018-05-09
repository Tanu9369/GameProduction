using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {


    public static AudioClip bgmSound;
    static AudioSource audioSrc;
	// Use this for initialization
	void Start () {
        bgmSound = Resources.Load<AudioClip>("bgm");

        audioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void PlaySound(string clip)
    {
        switch (clip)
        {

        }
    }
}
