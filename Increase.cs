using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Increase : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Positive")
        {
            PositiveVibes.vibeCount = PositiveVibes.vibeCount + 1;
            PositiveVibes.totalVibes = PositiveVibes.totalVibes - 1;
            Destroy(collision.gameObject);
        }
    }
}
