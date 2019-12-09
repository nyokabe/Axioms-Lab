using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballReduceForce : MonoBehaviour
{
    private float[] ForceXYZ = new float[3];
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(stopGravity(3));
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this, 5f);

    }
    IEnumerator stopGravity(int i)
    {
        rb.useGravity = false;
        rb.constraints = RigidbodyConstraints.FreezeRotationX;
        Debug.Log("It's working");
        yield return new WaitForSeconds(i);
        rb.useGravity = true;
        //rb.constraints = RigidbodyConstraints.None;

    }
    
}
