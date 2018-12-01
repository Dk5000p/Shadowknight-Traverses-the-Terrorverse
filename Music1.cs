using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {
    public AudioSource Musicplay;
	// Use this for initialization
	void Start () {
        Musicplay.PlayDelayed(33f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
