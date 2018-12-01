using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worlds : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("Ancient", 0);
        PlayerPrefs.SetInt("Clownlevel", 0);
        PlayerPrefs.SetInt("GB",0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
