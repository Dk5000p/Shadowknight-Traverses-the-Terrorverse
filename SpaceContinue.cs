using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceContinue : MonoBehaviour {
    public int scene;
    public float waitTime;
    public float Timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space)&&Timer>waitTime)
        {
            SceneManager.LoadScene(scene);
        }
	}
}
