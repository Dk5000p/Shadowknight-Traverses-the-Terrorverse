using UnityEngine;
using UnityEngine.SceneManagement;

public class Mouse : MonoBehaviour {
    public int scene;
    public SpriteRenderer m_SpriteRenderer;
    //The Color to be assigned to the Renderer’s Material
    public Color m_NewColor;
    private void Awake()
    {

        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }
        private void OnMouseDown()
    
    {
        SceneManager.LoadScene(scene);
    }
    private void OnMouseEnter()
    {
        m_SpriteRenderer.color = Color.green;
    }
    private void OnMouseExit()
    {
        m_SpriteRenderer.color = Color.white;
    }
}
