using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
    public AudioSource boom;
    public float Timer;
    public GameObject cloud;
    public bool explode;
    private void Start()
    {
        explode = true;
        Destroy(gameObject, 2f);
        boom.Play();
    }
    private void Update()
    {
        Timer += Time.deltaTime;
       
        if (Timer >= 0.8f&&explode==true)
        {
            Instantiate(cloud, transform.position, transform.rotation);
            boom.Play();
            Timer = 0;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            boom.Play();
            Health.HealthAmount = Health.HealthAmount - 10;
          
            Destroy(gameObject);
        }
    }
}
