﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endSwing : MonoBehaviour
{
    public GameObject endBall;
    public bool reverse = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

     void OnTriggerEnter(Collider other)
     {
        reverse = true;
     }
       /* if (collision.gameObject == endBall)
        {
            reverse = true;
        }*/
// Update is called once per frame
    void Update()
    {
        
    }
}