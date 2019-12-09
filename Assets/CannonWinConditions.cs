using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonWinConditions : MonoBehaviour
{
    public bool gM1;
    public bool gM2;
    public bool gM3;

    public int Points;

    public Text winText;

    public MainControl mc;


    // Start is called before the first frame update
    void Start()
    {
        Points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        WinConditions();
    }

    void WinConditions()
    {
        if (Points == 3)
        {
            mc.winCannon = true;
        }
    }
}
