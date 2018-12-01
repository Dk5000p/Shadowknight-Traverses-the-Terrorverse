using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject Energy;
    public GameObject Energy2;
    public Transform Location;
    public Transform Location2;
    private float timeBtwShots;
    public float startTimeBtwShots;
    private Transform player;
    public GameObject projectile;
    // Use this for initialization
    void Start () {
        timeBtwShots = startTimeBtwShots;
        player = GameObject.FindGameObjectWithTag("Player").transform;
       
	}
	
	// Update is called once per frame
	void Update () {
        if (timeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
   

    }

