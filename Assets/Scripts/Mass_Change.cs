using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mass_Change : MonoBehaviour
{
    public float mass;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mass = 1.00f;
        rb.mass = mass;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            rb.mass += 1.00f;
            mass += 1.00f;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            rb.mass -= 1.00f;
            mass -= 1.00f;
        }

    }
}
