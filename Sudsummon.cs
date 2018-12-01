using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sudsummon : MonoBehaviour {
    public GameObject sud;
    public Transform location;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Suds", 1f, 2f);
	}
	
	void Suds()
    {
        Instantiate(sud, location.position, location.rotation);
    }
}
