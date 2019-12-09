using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cannonScript : MonoBehaviour
{
    public float[] ForceXYZ = new float[3];
    public GameObject ball;
    public GameObject Launcher;
    public TextMesh ForceText;
    public Rigidbody ballRB;
    public int converted;
    public bool activateBall = false;
    AudioSource c_CannonFire;

    private void Start()
    {
        c_CannonFire = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (Input.GetKeyDown("x"))
        {
            spawnBall();
        }

        ForceText.text = "Force: " + converted;

        ball.GetComponent<ConstantForce>().relativeForce = new Vector3(0, converted, 0);

    }


    /*IEnumerator stopGravity(int i)
    {
        ball.GetComponent<ConstantForce>().relativeForce = new Vector3(0, ForceXYZ[1], converted);
        ballRB.useGravity = false;
        ballRB.constraints = RigidbodyConstraints.FreezeRotationX;
        Debug.Log("It's working");
        yield return new WaitForSeconds(i + 100);
        ballRB.useGravity = true;
        ballRB.constraints = RigidbodyConstraints.None;
    }
    */
    public void spawnBall()
    {
        Instantiate(ball, Launcher.transform);
        activateBall = true;
        c_CannonFire.Play();
        //StartCoroutine(stopGravity(converted));
    }

}
