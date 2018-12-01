using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour {
    public ParticleSystem blood;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Health.HealthAmount = Health.HealthAmount - 10;
            Instantiate(blood,transform.position, transform.rotation);
         
            Destroy(gameObject);
        }else if (collision.tag == "Wall")
        {
            Destroy(gameObject);
        }else if (collision.tag == "Shield")
        {
            Destroy(gameObject);
        }
    }
   
    }

