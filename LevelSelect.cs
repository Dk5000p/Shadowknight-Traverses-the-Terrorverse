using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {
    public int scene;
    public SpriteRenderer m_SpriteRenderer;
    //The Color to be assigned to the Renderer’s Material
    public Color m_NewColor;

    // Use this for initialization
    void Start () {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            m_SpriteRenderer.color = Color.green;
        }
        if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.Space))
        {
            
            SceneManager.LoadScene(scene);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            m_SpriteRenderer.color = Color.white;
        }
    }
}
