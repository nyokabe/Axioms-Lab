using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRampCol : MonoBehaviour
{
    public GameObject LabInsides;
    // Start is called before the first frame update
    void Start()
    {
        LabInsides.GetComponent<MainControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Green_button(2)")
        {

            LabInsides.GetComponent<MainControl>().SetLevelBallRollActive();
        }
    }
}
