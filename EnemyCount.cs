﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCount : MonoBehaviour {
    public static int count;
    public int scene;
	// Use this for initialization
	void Start () {
        count = 2;
	}
	
	// Update is called once per frame
	void Update () {
        if (count <= 0)
        {
            SceneManager.LoadScene(scene);
        }
	}
}