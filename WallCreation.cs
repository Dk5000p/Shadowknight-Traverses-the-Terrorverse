using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCreation : MonoBehaviour {
    public GameObject Wall;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Instantiate(Wall, new Vector3(-25.314f, 12.387f, 0f), Quaternion.identity);
        }
    }
}
