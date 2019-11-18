using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollow : MonoBehaviour
{
    Vector3 cameraTargetRotation;
    Vector3 cameraCurrentRotation;
    Transform playerLocation;
    public GameObject Player;
    Transform player;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        player = Player.GetComponent(Transform);
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
