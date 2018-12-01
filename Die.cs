using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Blade")
        {
            ClownsDestroyed.Destroyed = ClownsDestroyed.Destroyed + 1;
            Destroy(gameObject);
        }
    }
}
