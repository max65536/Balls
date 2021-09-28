using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    SpriteRenderer sp;
    public Color[] foodcolor;
    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        int randnum = Random.Range(0, foodcolor.Length);
        sp.color = foodcolor[randnum];
        //Debug.Log("color="+randnum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Character")
        {
            NPC e = other.GetComponent<NPC>();
            e.grow();
            Destroy(gameObject);
        }
        if (other.tag == "Player")
        {
            Player e = other.GetComponent<Player>();
            e.grow();
            Destroy(gameObject);
        }
    }
}
