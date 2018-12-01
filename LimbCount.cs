using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbCount : MonoBehaviour {
    public int Limbs;
  
    public bool hit = false;
    private Transform player;

    // Use this for initialization
    void Start () {
        Limbs = 2;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        Debug.Log(Limbs);
	}

    // Update is called once per frame
    private void Update()
    {
        if (Limbs <= 0)
        {
            EnemyCount.count = EnemyCount.count - 1;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Blade"&&hit==false)
        {
            Debug.Log("Hit"+Limbs);
            Limbs = Limbs - 1;
            hit = true;

        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Blade")
        {
            hit = false;
        }
    }
}
  
    
        
    


