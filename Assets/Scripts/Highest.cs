using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Highest : MonoBehaviour
{
    public float highestPosition;
    public Text high;
    public double currentHigh = 0;
    public float currentY;
    public bool hasHit = false;
    private string a;

    // Start is called before the first frame update
    void Start()
    {
        highestPosition = 0;
        SetHighText();
        high.text = "Highest Bounce: ";
    }

    // Update is called once per frame
    void Update()
    {
        if (hasHit)
        {
            FindHighest();
        }
    }

    private void SetHighText()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            hasHit = true;
        }
    }

    private void FindHighest ()
    {
        currentY = transform.position.y;
        if (currentY > currentHigh)
        {
            currentHigh = currentY;
        }
        if (transform.position.y > highestPosition) highestPosition = transform.position.y;
        a = currentHigh.ToString("F2");
        high.text = "Highest Bounce: " + a;
    }
}
