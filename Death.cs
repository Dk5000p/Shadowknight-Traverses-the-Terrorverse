using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
    public GameObject[] enemies;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (enemies.Length==0 && collision.tag=="Blade")
        {
            EnemyCount.count = EnemyCount.count - 1;
            Destroy(gameObject);
        }
    }
}
