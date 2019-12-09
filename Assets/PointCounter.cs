using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public Text Points;
    public int Point;
    public MainControl mc;
    // Start is called before the first frame update
    void Start()
    {
        Point = 0;
        Points.text = "Current Points:" + Point;
    }

    // Update is called once per frame
    void Update()
    {
        Points.text = "Current Points:" + Point;
        if (Point == 10)
        {
            mc.Win();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Point = Point + 1;

    }
}
