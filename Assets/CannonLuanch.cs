using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonLuanch : MonoBehaviour
{
       public cannonScript cS;

    void OnTriggerEnter(Collider other)
    {
        cS.spawnBall();
    }
}
