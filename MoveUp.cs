using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour {

    public float speed = 10;
    Transform myTrans;
    Rigidbody2D my2d;
    public float maxY;
    public float minY;
    void Start()
    {
        my2d = this.GetComponent<Rigidbody2D>();
        myTrans = this.transform;

    }

    void FixedUpdate()
    {
        
        Move2(Input.GetAxisRaw("Vertical"));
      
    }
    public void Move2(float verticalInput)
    {
        Vector2 moveVel2 = my2d.velocity;
        if (transform.position.y < maxY && transform.position.y > minY)
        {
            moveVel2.y = verticalInput * speed;
            my2d.velocity = moveVel2;
        }
    }
}
