using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CradleCon : MonoBehaviour
{
    //short hand for the gameobjects
    public Transform StartB;
    public Transform B1;
    public Transform B2;
    public Transform B3;
    public Transform B4;
    public Transform RBall;
    public Transform Ball1;
    public Transform Ball2;
    public Transform Ball3;
    public Transform Ball4;
    public Transform LBall;
    public Transform startMark;
    public Transform endMark;
    Vector3 m_StartPos, m_StartForce;
    Vector3 m_newForce;
    Rigidbody m_Rigidbody;
    string m_ForceXString = string.Empty;
    string m_ForceYString = string.Empty;
    float m_ForceX, m_ForceY;
    float m_Result;
    float yLimit;
    float yMin;
    float xLimit;
    float xMin;
   
    public float speed;


    public float startTime;
    private float journeyLength;
    // Start is called before the first frame update
    void Start()
    {
        //m_Rigidbody = this.gameObject.gameObject.transform.GetChild(5).GetChild(0).GetComponent<Rigidbody>;
        
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMark.position, endMark.position);
        foreach (Transform child in transform)
        {
        
            RBall.position += Vector3.forward * 0.3f;
            RBall.position += Vector3.up * 0.1f;
            LBall.position += Vector3.back * 0.3f;
            LBall.position += Vector3.up * 0.1f;
        }
    }

    public void Assignment()
    {
        StartB = this.gameObject.gameObject.transform.GetChild(0);
        B1 = this.gameObject.gameObject.transform.GetChild(1);
        B2 = this.gameObject.gameObject.transform.GetChild(2);
        B3 = this.gameObject.gameObject.transform.GetChild(3);
        B4 = this.gameObject.gameObject.transform.GetChild(4);
        RBall = this.gameObject.gameObject.transform.GetChild(5).GetChild(0);
        Ball1 = this.gameObject.gameObject.transform.GetChild(5).GetChild(1);
        Ball2 = this.gameObject.gameObject.transform.GetChild(5).GetChild(2);
        Ball3 = this.gameObject.gameObject.transform.GetChild(5).GetChild(3);
        Ball4 = this.gameObject.gameObject.transform.GetChild(5).GetChild(4);
        LBall = this.gameObject.gameObject.transform.GetChild(5).GetChild(5);
        xLimit = .5f;
        xMin = -.5f;
        yLimit = .5f;
        yMin = -.5f;
    }

    public void movement()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // functional
        //RBall
        if (RBall.transform.position.z == 3.17f)
        {
            //RBall.transform.impusle;
            RBall.position = new Vector3(-5.13f, 3f, Mathf.PingPong(Time.time, 4) + 3.17f);
        } else
        {
            Vector3 newPosition = new Vector3(RBall.transform.position.x, RBall.transform.position.y, 3.169f);
            RBall.transform.position = newPosition;
        }
        //Ball1
        if (Ball1.transform.position.x == 2.1f)
        {
            //Ball1.transform.impusle;
            Ball1.position = new Vector3(-5.13f, 3f, Mathf.PingPong(Time.time, 4) + 2.1f);
        }
        else
        {
            Vector3 newPosition = new Vector3(Ball1.transform.position.x, Ball1.transform.position.y, 1.996f);
            Ball1.transform.position = newPosition;
        }
        //Ball2
        if (Ball2.transform.position.x == 1.058f)
        {
            //Ball2.transform.impusle;
            Ball2.position = new Vector3(-5.13f, 3f, Mathf.PingPong(Time.time, 4) + 1.058f);
        }
        else
        {
            Vector3 newPosition = new Vector3(Ball2.transform.position.x, Ball2.transform.position.y, 0.936f);
            Ball2.transform.position = newPosition;
        }
        //Ball3
        if (Ball3.transform.position.x == 0f)
        {
            //Ball3.transform.impusle;
            Ball3.position = new Vector3(-5.13f, 3f, Mathf.PingPong(Time.time, 4) + 0f);
        }
        else
        {
            Vector3 newPosition = new Vector3(Ball3.transform.position.x, Ball3.transform.position.y, -.11f);
            Ball3.transform.position = newPosition;
        }
        //Ball4
        if (Ball4.transform.position.x == -1.057f)
        {
            //Ball4.transform.impusle;
            Ball4.position = new Vector3(-5.13f, 3f, Mathf.PingPong(Time.time, 4) + -1.057f);
        }
        else
        {
            Vector3 newPosition = new Vector3(Ball4.transform.position.x, Ball4.transform.position.y, -1.277f);
            Ball4.transform.position = newPosition;
        }
        //LBall
        if (LBall.transform.position.x == -2.213f)
        {
            //LBall.transform.impusle;
            LBall.position = new Vector3(-5.13f, 3f, Mathf.PingPong(Time.time, 4) + -2.213f);
        }
        else
        {
            Vector3 newPosition = new Vector3(LBall.transform.position.x, LBall.transform.position.y, -3f);
            LBall.transform.position = newPosition;
        }

        //non-functional below
        /*//limits the X position
        //Rball
        if (RBall.transform.position.x > xLimit)
        {
            Vector3 newPositionX = new Vector3(0f, transform.position.y, transform.position.z);
            RBall.transform.position = newPositionX;
        }
        else if (RBall.transform.position.x < xMin)
        {
            Vector3 newPositionX = new Vector3(0f, transform.position.y, transform.position.z);
            RBall.transform.position = newPositionX;
        }
        //ball1
        if (Ball1.transform.position.x > xLimit)
        {
            Vector3 newPositionX = new Vector3(0f, transform.position.y, transform.position.z);
            Ball1.transform.position = newPositionX;
        } else if (Ball1.transform.position.x < xMin)
        {
            Vector3 newPositionX = new Vector3(0f, transform.position.y, transform.position.z);
            Ball1.transform.position = newPositionX;
        }
        //ball2
        if (Ball2.transform.position.x > xLimit)
        {
            Vector3 newPositionX = new Vector3(0f, transform.position.y, transform.position.z);
            Ball2.transform.position = newPositionX;
        }
        else if (Ball2.transform.position.x < xMin)
        {
            Vector3 newPositionX = new Vector3(0f, transform.position.y, transform.position.z);
            Ball2.transform.position = newPositionX;
        }
        //ball3
        if (Ball3.transform.position.x > xLimit)
        {
            Vector3 newPositionX = new Vector3(0f, transform.position.y, transform.position.z);
            Ball3.transform.position = newPositionX;
        }
        else if (Ball3.transform.position.x < xMin)
        {
            Vector3 newPositionX = new Vector3(0f, transform.position.y, transform.position.z);
            Ball3.transform.position = newPositionX;
        }
        //ball4
        if (Ball4.transform.position.x > xLimit)
        {
            Vector3 newPositionX = new Vector3(0f, transform.position.y, transform.position.z);
            Ball4.transform.position = newPositionX;
        }
        else if (Ball4.transform.position.x < xMin)
        {
            Vector3 newPositionX = new Vector3(0f, transform.position.y, transform.position.z);
            Ball4.transform.position = newPositionX;
        }
        //Lball
        if (LBall.transform.position.x > xLimit)
        {
            Vector3 newPositionX = new Vector3(0f, transform.position.y, transform.position.z);
            LBall.transform.position = newPositionX;
        }
        else if (LBall.transform.position.x < xMin)
        {
            Vector3 newPositionX = new Vector3(0f, transform.position.y, transform.position.z);
            LBall.transform.position = newPositionX;
        }


        //limits Y positsion
        //ball1
        if (Ball1.transform.position.y > yLimit)
        {
            Vector3 newPositionY = new Vector3(transform.position.x, 0f, transform.position.z);
            Ball1.transform.position = newPositionY;
        }
        else if (Ball1.transform.position.y < yMin)
        {
            Vector3 newPositionY = new Vector3(transform.position.x, 0f, transform.position.z);
            Ball1.transform.position = newPositionY;
        }
        //ball2
        if (Ball2.transform.position.y > xLimit)
        {
            Vector3 newPositionY = new Vector3(transform.position.x, 0f, transform.position.z);
            Ball2.transform.position = newPositionY;
        }
        else if (Ball2.transform.position.y < xMin)
        {
            Vector3 newPositionY = new Vector3(transform.position.x, 0f, transform.position.z);
            Ball2.transform.position = newPositionY;
        }
        //ball3
        if (Ball3.transform.position.x > xLimit)
        {
            Vector3 newPositionX = new Vector3(0f, transform.position.y, transform.position.z);
            Ball3.transform.position = newPositionX;
        }
        else if (Ball3.transform.position.x < xMin)
        {
            Vector3 newPositionX = new Vector3(0f, transform.position.y, transform.position.z);
            Ball3.transform.position = newPositionX;
        }
        //ball4
        if (Ball4.transform.position.x > xLimit)
        {
            Vector3 newPositionX = new Vector3(0f, transform.position.y, transform.position.z);
            Ball4.transform.position = newPositionX;
        }
        else if (Ball4.transform.position.x < xMin)
        {
            Vector3 newPositionX = new Vector3(0f, transform.position.y, transform.position.z);
            Ball4.transform.position = newPositionX;
        }*/
    }
       
       /* float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        RBall.position = Vector3.Lerp(startMark.position, endMark.position, fracJourney);*/
    
}
