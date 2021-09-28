using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public GameObject npc;
    public float Xmin = -14.6f;
    public float Xmax = 14.6f;
    public float Ymin = -14.6f;
    public float Ymax = 14.6f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateNPC", 0, 2.0f);
        //GameObject npc0 = Instantiate(npc, new Vector2(0,0), Quaternion.identity);
        //npc0.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateNPC()
    {
        float x = Random.Range(Xmin, Xmax);
        float y = Random.Range(Ymin, Ymax);

        Instantiate(npc, new Vector2(x,y), Quaternion.identity);
    }
}
