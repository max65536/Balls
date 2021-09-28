using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        KeyControl();
    }

    void KeyControl()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rigidboddy2D.velocity = Vector2.left*speed;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rigidboddy2D.velocity = Vector2.right*speed;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rigidboddy2D.velocity = Vector2.up*speed;
        }        
        if (Input.GetKeyDown(KeyCode.S))
        {
            rigidboddy2D.velocity = Vector2.down*speed;
        }        
    }

    private new void OnTriggerEnter2D(Collider2D other) {
        //base.OnTriggerEnter2D(other);
        if (other.tag == "food")
        {
            grow();
        }
    }
}
