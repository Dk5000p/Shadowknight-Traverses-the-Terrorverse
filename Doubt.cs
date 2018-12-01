using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doubt : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Shield")
        {
            Destroy(gameObject);
        }
        if (collision.tag == "Player")
        {
            PositiveVibes.vibeCount = PositiveVibes.vibeCount - 1;
            Destroy(gameObject);
        }
    }
}
