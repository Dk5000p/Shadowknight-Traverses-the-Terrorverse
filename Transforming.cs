using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transforming : MonoBehaviour {
    public Animator anim;
    public float Timer;
    public GameObject Enemy;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= 33)
        {
            anim.Play("Transformation");
            Instantiate(Enemy, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

