using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorAttack : MonoBehaviour {
    public AudioSource meteorDamage;
    
    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Health.HealthAmount = Health.HealthAmount - 20;
            meteorDamage.Play();
            Destroy(gameObject);
        }
    }
}
