using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAncient : MonoBehaviour {
    public int levelstatus;
	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("Ancient", 1);
        levelstatus = PlayerPrefs.GetInt("Ancient", 0);
        Debug.Log(levelstatus);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
