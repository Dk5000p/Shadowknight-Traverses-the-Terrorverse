using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealFinalLevel : MonoBehaviour {
    public int AncientValue;
    public int ClownValue;
    public int SpeakingValue;
    public int total;
	// Use this for initialization
	void Start () {
        ClownValue=PlayerPrefs.GetInt("Clownlevel", 0);
        AncientValue= PlayerPrefs.GetInt("Ancient", 0);
        SpeakingValue= PlayerPrefs.GetInt("GB", 0);
        total = SpeakingValue + AncientValue + ClownValue;
    }
	
	// Update is called once per frame
	void Update () {
        if (total == 3)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
	}
}
