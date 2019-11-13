using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttionCon : MonoBehaviour
{
    public GameObject playerHR;
    public GameObject playerHL;
    public bool activeated;
    Rigidbody rb;
    Rigidbody RH;
    Rigidbody LH;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //RH = playerHR.GetComponent<Rigidbody>();
        //LH = playerHL.GetComponent<Rigidbody>();
        //collPHR = playerHR.GetComponent<Collider>;
        activeated = false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == playerHR || collision.gameObject == playerHL)
        {
            activeated = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
