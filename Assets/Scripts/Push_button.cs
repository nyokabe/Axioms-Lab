using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push_button : MonoBehaviour { 
  
  
    [SerializeField]
    private Transform boxPrefab;
    [SerializeField]
    private Transform spawnPoint;

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
        if(other.tag=="Green_button(2)")
        {

            Transform t = Instantiate(boxPrefab);
            t.position = spawnPoint.position;
        }
    }
}
