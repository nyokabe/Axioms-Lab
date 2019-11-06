using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public bool ballDrop;
    public bool ballRoll;
    public bool cannon;
    public bool newton;
    

    // Start is called before the first frame update
    void Start()
    {
        ballDrop = true;
        ballRoll = false;
        newton = false;
        cannon = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Transitions()
    {
    }
}
