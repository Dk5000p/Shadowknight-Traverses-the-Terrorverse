using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sudblast : MonoBehaviour {
    private void Awake()
    {
        Destroy(gameObject, 0.5f);
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Health.HealthAmount = Health.HealthAmount - 5;
        }
    }
}
