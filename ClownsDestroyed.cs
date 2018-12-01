using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClownsDestroyed : MonoBehaviour {
    public static int Destroyed;
    public Text Count;
	// Use this for initialization
	void Start () {
        Destroyed = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Count.text = "Clowns Destroyed: " + Destroyed.ToString();
	}
}
