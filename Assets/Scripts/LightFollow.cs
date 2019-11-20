using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollow : MonoBehaviour
{
    Vector3 cameraTargetRotation;
    Vector3 cameraCurrentRotation;
    Vector3 playerLocation;
    public GameObject Player;
  
    float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        playerLocation = Player.transform.position;
        cameraTargetRotation = playerLocation - transform.position;
        
        float step = speed * Time.deltaTime;

        cameraCurrentRotation = Vector3.RotateTowards(transform.forward, cameraTargetRotation, step, 0.0f);
        Debug.DrawRay(transform.position, cameraCurrentRotation, Color.red);

        transform.rotation = Quaternion.LookRotation(cameraCurrentRotation);
    }
}
