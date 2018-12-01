using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    public AudioSource Indestructible;
    public float timer;
    public bool countup;
    private void Awake()
    {
        countup = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }else if (collision.tag == "Robot")
        {
            if (timer==0f && countup==true)
            {
                timer += Time.deltaTime;
                Indestructible.Play();
                countup = false;
            }else if (countup==false)
            {
                timer = 0;
                countup = true;
            }
        }
    }
}
