using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnervillain : MonoBehaviour {
    public List<GameObject> enemies1;
    public GameObject[] enemies2;
    public List<Vector2> locations;
    public Vector2 location;
    public GameObject Clown;
    public float spawntime;
    // Use this for initialization
    void Start () {
        InvokeRepeating("Spawn", 0, spawntime);
    }

	
	// Update is called once per frame
	void Update () {
		
	}



void Spawn()
{
    int index = Random.Range(0, locations.Count);
    int index2 = Random.Range(0, enemies1.Count);
        Vector2 location = locations[index];
    Clown = enemies1[index2];
    Instantiate(Clown, location, Quaternion.identity);
}
}

