using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enter : MonoBehaviour {
    public AudioSource Nope;
    public bool enter;
    public int scene;
    private void Start()
    {
        enter = false;
        Nope.PlayDelayed(11f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "Player" && ClownsDestroyed.Destroyed>=10)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
