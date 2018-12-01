using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour {
    private float timeBtwShots;
    public float startTimeBtwShots;
    private Transform player;
    public GameObject projectile;
    // Use this for initialization
    void Start()
    {
        timeBtwShots = startTimeBtwShots;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        if (timeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
        if (player.transform.position.x < transform.position.x)
        {
            transform.localScale = new Vector2(-0.2060894f, 0.2273378f);
        }
        else if (player.transform.position.x > transform.position.x)
        {
            transform.localScale = new Vector2(0.2060894f, 0.2273378f);
        }
    }
}