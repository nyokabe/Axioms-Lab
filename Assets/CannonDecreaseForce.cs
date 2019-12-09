using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonDecreaseForce : MonoBehaviour
{
       public cannonScript cS;

    void OnTriggerEnter(Collider other)
    {
        cS.converted -= 1;
    }
}
