using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Completed : MonoBehaviour {
    public int level;

	// Use this for initialization
	void Start () {
        level=PlayerPrefs.GetInt("GB", 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (level == 1)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
