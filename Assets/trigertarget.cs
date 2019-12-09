using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigertarget : MonoBehaviour
{
    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        Target.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Target.SetActive(true);
    }
}
