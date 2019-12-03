using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bye : MonoBehaviour
{
    public void Update()
    {

        
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(gameObject);
            }
        
    }
}
