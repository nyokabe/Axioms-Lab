using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirTrigger : MonoBehaviour
{
    public MainControl ms;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        ms.winDrop=true;
    }
}
