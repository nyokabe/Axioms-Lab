using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snapActions : MonoBehaviour
{
    public cannonScript cS;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void decreaseForce()
    {
        cS.converted -= 1;
    }

    public void increaseForce()
    {
        cS.converted += 1;
    }

    public void createBall()
    {
        cS.spawnBall();
    }
}
