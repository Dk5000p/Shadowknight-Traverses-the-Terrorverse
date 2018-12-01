using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessDenied : MonoBehaviour {
    public AudioSource Denied;
    public AudioSource Welcome;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Inventory.VHSCard == false&&collision.tag=="Player")
        {
            Denied.Play();
        }else if (Inventory.VHSCard == true && collision.tag == "Player")
        {
            Welcome.Play();
            Destroy(gameObject);
        }
    }
}
