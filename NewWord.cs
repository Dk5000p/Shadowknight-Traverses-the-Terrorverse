﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWord : MonoBehaviour {
    public GameObject Positive;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Door")
        {
            Instantiate(Positive, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
