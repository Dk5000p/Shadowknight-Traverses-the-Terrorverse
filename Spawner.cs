using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject[] Clowns;
    public List<Vector2> locations;
    public Vector2 location;
    public GameObject Clown;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", 0, 2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Spawn()
    {
        int index = Random.Range(0, locations.Count);
        Vector2 location = locations[index];
        Clown = Clowns[index];
        Instantiate(Clown, location, Quaternion.identity);
    }
}
