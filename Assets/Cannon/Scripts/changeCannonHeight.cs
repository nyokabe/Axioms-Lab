using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCannonHeight : MonoBehaviour
{
    public GameObject cannon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LeftHand"))
        {
            cannon.transform.Rotate(0, 0, -10, Space.Self);
            Debug.Log("It works");
        }

        if (other.gameObject.CompareTag("RightHand"))
        {
            cannon.transform.Rotate(0, 0, 10, Space.Self);
        }
    }
}
