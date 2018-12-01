using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject projectile;
    public GameObject Bullet_Emitter;
    private float waitTime;
    public float startWaitTime;
    private void Start()
    {

        waitTime = startWaitTime;
        InvokeRepeating("shoot", 0f, 3f);
    }



    private void shoot()
    {
        Debug.Log("Shoot");
        Instantiate(projectile, Bullet_Emitter.transform.position, Quaternion.identity);

    }
}