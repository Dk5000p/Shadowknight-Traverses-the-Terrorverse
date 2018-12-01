using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour {
    public GameObject book;
    public GameObject book2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            book2=Instantiate(book, new Vector2(transform.position.x, transform.position.y-2), transform.rotation);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(book2.gameObject);
    }
}
