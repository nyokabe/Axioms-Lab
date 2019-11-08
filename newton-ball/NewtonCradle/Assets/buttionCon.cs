using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttionCon : MonoBehaviour
{
    public GameObject playerHR;
    public GameObject playerHL;
    public bool activeated;
    // Start is called before the first frame update
    void Start()
    {
        //collPHR = playerHR.GetComponent<Collider>;
        activeated = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == playerHR || collision.gameObject == playerHL)
        {
            activeated = true;
            activeated = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
