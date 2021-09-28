using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 2.0f;
    public int direction;
    protected Rigidbody2D rigidboddy2D;
    protected int size=0;

    public int minimum =1;
    public int maximum =5;
    void Awake() {
        rigidboddy2D = GetComponent<Rigidbody2D>();
        Debug.Log("direction="+direction+" name:"+this.name);
    }

    // Start is called before the first frame update
    protected void Start()
    {
        direction = Random.Range(minimum, maximum);
        Init();
    }

    // Update is called once per frame
    void Update()
    {
    }

    protected void Init()
    {
        if (direction == 1)
        {
            rigidboddy2D.velocity = Vector2.left * speed;
        }
        if (direction == 2)
        {
            rigidboddy2D.velocity = Vector2.right * speed;
        }
        if (direction == 3)
        {
            rigidboddy2D.velocity = Vector2.up * speed;
        }
        if (direction == 4)
        {
            rigidboddy2D.velocity = Vector2.down * speed;
        }                        
    }

    protected virtual void OnTriggerEnter2D(Collider2D other) 
    {

    }

    public void grow()
    {
        if (size>30) return;
        transform.localScale += new Vector3(0.3f,0.3f,0.3f);        
        size++;
    }
}
