using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Character
{
    public GameObject searchRange;
    private Transform myTransform;
    private Food food;
    new void Start() {
        base.Start();
        myTransform = this.transform;
    }
    void SearchforFood()
    {
        
    }

    void Update()
    {
        myTransform = this.transform;
    }

    private new void OnTriggerEnter2D(Collider2D other) {
        //base.OnTriggerEnter2D(other);
        if (other.tag == "food")
        {
            if (!food) 
            {
                food = other.GetComponent<Food>();
                Debug.Log("other:"+other+" me:"+myTransform);
                Vector2 new_direction = (other.transform.position - myTransform.position);
                Debug.Log("distance = "+(new_direction));
                rigidboddy2D.velocity = new_direction.normalized * speed;
            }
        }
    }

}

