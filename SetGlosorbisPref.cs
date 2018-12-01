using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGlosorbisPref : MonoBehaviour {
    public int levelstatus;
	// Use this for initialization
	void Start () {
      PlayerPrefs.SetInt("GB", 1);
        levelstatus = PlayerPrefs.GetInt("GB", 0);
        Debug.Log(levelstatus);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
