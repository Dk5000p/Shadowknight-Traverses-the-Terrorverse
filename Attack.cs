using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    public Animator anim;
    public BoxCollider2D box;
    public PolygonCollider2D polygon;
    // Use this for initialization
    void Start()
    {
      box = gameObject.transform.GetChild(0).GetComponent<BoxCollider2D>();
    polygon= gameObject.transform.GetChild(0).GetComponent<PolygonCollider2D>();
        box.enabled = false;
        polygon.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            box=gameObject.transform.GetChild(0).GetComponent<BoxCollider2D>();
            box.enabled = true;
            polygon.enabled = true;
            Debug.Log("Space Pressed");
            anim.Play("SwordAttack");
        }
        else
        {
            
            box.enabled = false;
            polygon.enabled = false;
        }
    }
}
