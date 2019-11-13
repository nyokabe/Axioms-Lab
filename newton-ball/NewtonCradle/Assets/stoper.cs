using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoper : MonoBehaviour
{
    public GameObject starter;
    public bool st = true;
    public GameObject nextBall;
    public GameObject otherBall;
    public GameObject finalBall;
    public bool returningBall;

   // public GameObject endSwingR;
   // public GameObject StartB;
    /*public Vector3 Force;
    public Vector3 R_Force;*/
    //bool endSwing = false;
    //bool stopPoint = false;

    public enum ModeSwitching { Start, Impulse, Acceleration, Force, VelocityChange };
    public ModeSwitching m_modeSwitching;
    Vector3 m_StartPos, m_StartForce;
    Vector3 m_NewForce;
    Rigidbody m_Rigidbody;
    Rigidbody SP;
   // Rigidbody ES;

    string m_ForceYString = string.Empty;
    string m_ForceXString = string.Empty;

    float m_ForceY, m_ForceX;
    float m_Result;
    // Start is called before the first frame update
    void Start()
    {
        returningBall = false;
        GameObject.FindGameObjectWithTag("final_ball");
        m_Rigidbody = GetComponent<Rigidbody>();
        m_modeSwitching = ModeSwitching.Start;
        m_NewForce = new Vector3(0, 0, 0);
        m_ForceX = 0;
        m_ForceY = 0;
        m_ForceXString = "1";
        m_ForceYString = "0";
        m_StartPos = transform.position;
        m_StartForce = m_Rigidbody.transform.position;
       // SP = nextBall.GetComponent<Rigidbody>();
       // ES = endSwingR.GetComponent<Rigidbody>();

    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if (st == false)
        {
            if (collision.gameObject.tag == "final_ball")
            {
                //returningBall = true;
                m_ForceX = m_ForceX * -1f;
                st = true;
            }
            if (collision.gameObject == nextBall)
            {
                nextBall.GetComponent<stoper>().returningBall = true;
                m_ForceX = m_ForceX * -1f;
                st = true;
            }
            if (collision.gameObject.tag == "start_ball")
            {
                m_ForceX = m_ForceX * -1;
                st = true;
                gameObject.GetComponent<ballCon>().stop = false;
            }
           st = true;
        } else if (st == true)
        {
            if (collision.gameObject.tag == "start_ball")
            {
                returningBall = false;
                st = false;
            }
            if (collision.gameObject == otherBall)
            {
                otherBall.GetComponent<stoper>().returningBall = false;
                st = true;
            }
       /*     if (collision.gameObject.GetComponent<stoper>().returningBall == true)
            {
                returningBall = false;
                m_ForceX = m_ForceX * -1f;
            } else*/
            st = false;
        }

       /* if (collision.gameObject.tag == "finalBall")
        {
            this.m_modeSwitching = ModeSwitching.Start;
            nextBall.GetComponent<stoper>().st = true;
        }*/

    }

    void FixedUpdate()
    {
        if (m_modeSwitching != ModeSwitching.Start)
        {
            m_NewForce = new Vector3(m_ForceX, m_ForceY, 0);
        }
        switch (m_modeSwitching)
        {
            case ModeSwitching.Start:
                transform.position = m_StartPos;
                m_Rigidbody.transform.position = m_StartForce;
                m_Rigidbody.velocity = new Vector3(0f, 0f, 0f);
                break;

            case ModeSwitching.Force:
                // if (endSwingR.GetComponent<endSwing>().reverse == false)
                //{
                MakeCustomForce();
                m_Rigidbody.AddForce(m_NewForce, ForceMode.Force);
                break;
            /*} else 
            if (endSwingR .GetComponent<endSwing>().reverse == true)
            {

            }*/
           
        }

        if (st == false)
        {
            m_NewForce = new Vector3(m_ForceX, m_ForceY, 0);
            m_modeSwitching = ModeSwitching.Force;
        } else if (st == true)
        {
            m_modeSwitching = ModeSwitching.Start;
        }

        if (returningBall == true)
        {
            m_ForceX = m_ForceX * -1f;
        }

        //reverse the swing when it collides with the box collider
       /* if (st == true)
        {
            m_NewForce = new Vector3(m_ForceX, m_ForceY, 0);
            m_modeSwitching = ModeSwitching.Force;
            //m_Rigidbody.AddForce(m_NewForce, ForceMode.Force);
        }
        //stops the swinging when it hits the next ball
        if (nextBall.GetComponent<stoper>().st == true)
        {
            m_modeSwitching = ModeSwitching.Start;
            this.st = false;
        }
        /*if (finalBall.GetComponent<reverseBallCon>().st == true)
        {
           // m_ForceX = m_ForceX * -1;
            m_modeSwitching = ModeSwitching.Start;
            this.st = false;
        }*/
        /*else if (this.st == false) {
            m_ForceX = m_ForceX * -1;
            m_modeSwitching = ModeSwitching.Force;
        }*/
 
    }

    float ConvertToFloat(string name)
    {
        float.TryParse(name, out m_Result);
        return m_Result;
    }

    void MakeCustomForce()
    {
            m_ForceX = ConvertToFloat(m_ForceXString) * -1;
            m_ForceY = ConvertToFloat(m_ForceYString) * -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
