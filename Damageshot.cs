using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageshot : MonoBehaviour {
        public AudioSource Bang;
	
        Rigidbody2D my2d;
        // Use this for initialization
        void Start()
        {
            my2d = this.GetComponent<Rigidbody2D>();
            my2d.AddForce(transform.right * 180f);
        }
    private void Update()
    {
        Destroy(gameObject, 3f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Health.HealthAmount = Health.HealthAmount - 15;
            Destroy(gameObject);
        }else if (collision.tag == "Shield")
        {
            Bang.Play();
            Destroy(gameObject);
        }
    }
}
