using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject food;
    public float Xmin = -14.6f;
    public float Xmax = 14.6f;
    public float Ymin = -14.6f;
    public float Ymax = 14.6f;
    void Start()
    {
        InvokeRepeating("GenerateFood", 0, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        //GenerateFood();
    }

    public void GenerateFood()
    {
        float x = Random.Range(Xmin, Xmax);
        float y = Random.Range(Ymin, Ymax);

        Instantiate(food, new Vector2(x,y), Quaternion.identity);
    }
}
