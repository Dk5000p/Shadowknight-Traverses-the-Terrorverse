using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    public static int HealthAmount;
    public Text HealthText;
    public int scene;
	// Use this for initialization
	void Start () {
        HealthAmount = 100;
	}
	
	// Update is called once per frame
	void Update () {
        HealthText.text = "Health:" + HealthAmount.ToString();
        if (HealthAmount <= 0)
        {
            SceneManager.LoadScene(scene);
        }
	}
}
