using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroysecs : MonoBehaviour {
    public float timesecs;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, timesecs);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
