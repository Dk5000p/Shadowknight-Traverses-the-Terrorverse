using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10;
    Transform myTrans;
    Rigidbody2D my2d;
    void Start()
    {
        my2d = this.GetComponent<Rigidbody2D>();
        myTrans = this.transform;

    }

    void FixedUpdate()
    {
        Move(Input.GetAxisRaw("Horizontal"));
        Move2(Input.GetAxisRaw("Vertical"));
        if (Input.GetButtonDown("1"))
        {
            Debug.Log("Button 1 pressed");
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }
        if (Input.GetButtonDown("2"))
        {
            Debug.Log("Button 2 pressed");
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }

    }

    public void Move(float horizontalInput)
    {
        Vector2 moveVel = my2d.velocity;
        moveVel.x = horizontalInput * speed;
        my2d.velocity = moveVel;
        if (moveVel.x < 0)
        {
            myTrans.localScale = new Vector2(-1f, 1f);
        }
        if (moveVel.x > 0)
        {
            myTrans.localScale = new Vector2(1f, 1f);
        }
    }
    public void Move2(float verticalInput)
    {
        Vector2 moveVel2 = my2d.velocity;
        moveVel2.y = verticalInput * speed;
        my2d.velocity = moveVel2;
    }
}


