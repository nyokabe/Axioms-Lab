using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCon : MonoBehaviour
{
    public GameObject endSwingR;
    public GameObject StartB;
    /*public Vector3 Force;
    public Vector3 R_Force;*/
    public GameObject stoper;
    public bool stop;

    enum ModeSwitching { Start, Impulse, Acceleration, Force, VelocityChange};
    ModeSwitching m_modeSwitching;
    Vector3 m_StartPos, m_StartForce;
    public Vector3 m_NewForce;
    Rigidbody m_Rigidbody;
    Rigidbody SP;
    Rigidbody ES;

   //public string m_ForceYString = string.Empty;
   //public string m_ForceXString = string.Empty;

    public float m_ForceY, m_ForceX;
    public float X, Y;
    float m_Result;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_modeSwitching = ModeSwitching.Start;
        m_NewForce = new Vector3(0, 0, 0);
        m_ForceX = 1;
        m_ForceY = 1;
        X = m_ForceX;
        Y = m_ForceY;
        m_StartPos = transform.position;
        m_StartForce = m_Rigidbody.transform.position;
        SP = stoper.GetComponent<Rigidbody>();
        ES = endSwingR.GetComponent<Rigidbody>();
        stop = true;

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


        //reverse the swing when it collides with the box collider
         if (endSwingR.GetComponent<endSwing>().reverse == true)
         {
            m_NewForce = new Vector3 (m_ForceX, m_ForceY, 0);
            m_modeSwitching = ModeSwitching.Force;
            StartB.GetComponent<buttionCon>().activeated = false;
            //m_Rigidbody.AddForce(m_NewForce, ForceMode.Force);
         }
        // begins the swing when the start buttion is used functional
        if (StartB.GetComponent<buttionCon>().activeated == true)
        {
            stop = false;
            m_modeSwitching = ModeSwitching.Force;
        }

        //stops the swinging when it hits the next ball
        if (endSwingR.GetComponent<endSwing>().reverse == true)
        {
            m_NewForce = new Vector3(m_ForceX, m_ForceY, 0);
            m_modeSwitching = ModeSwitching.Force;
            // StartB.GetComponent<buttionCon>().activeated = false;
            //m_Rigidbody.AddForce(m_NewForce, ForceMode.Force);
        }
        // begins the swing when the start buttion is used functional


        //stops the swinging when it hits the next ball
        /* if (SP.GetComponent<stoper>().st == true)
         {
             m_modeSwitching = ModeSwitching.Start;
             endSwingL.GetComponent<endSwing>().reverse = false;
         }*/
        if (stop == true)
        {
            m_modeSwitching = ModeSwitching.Start;
        }
        else if (stop == false)
        {
            m_modeSwitching = ModeSwitching.Force;
        }
        /* if (SP.GetComponent<stoper>().st == false)
         {
            m_modeSwitching = ModeSwitching.Start;
            endSwingR.GetComponent<endSwing>().reverse = false;
         }*/

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == endSwingR)
        {
            m_modeSwitching = ModeSwitching.Force;
        }
        if (collision.gameObject == stoper)
        {
            if (m_modeSwitching == ModeSwitching.Start)
            {
                m_ForceX = m_ForceX + 0.3f;
                m_ForceX = m_ForceX * -1;
                m_ForceY = m_ForceY + 0.3f;
                m_ForceY = m_ForceY * -1;
                stop = false;
               // m_modeSwitching = ModeSwitching.Force;
                //   m_modeSwitching = ModeSwitching.Force;
            }
            if (m_modeSwitching == ModeSwitching.Force)
            {
                m_modeSwitching = ModeSwitching.Start;
                stop = true;
             //   m_NewForce = m_NewForce * -1;
                endSwingR.GetComponent<endSwing>().reverse = false;
                //   m_modeSwitching = ModeSwitching.Start;
            }
        }
       /* if (collision.gameObject.GetComponent<stoper>().returningBall == true)
        {
            m_modeSwitching = ModeSwitching.Force;
        }*/
    }

        /* void OnCollisionEnter(Collision collision)
         {
             if (collision.gameObject.tag == "mid_ball")
             {
                 if (m_modeSwitching == ModeSwitching.Force)
                 {
                     m_modeSwitching = ModeSwitching.Start;
                     StartB.GetComponent<buttionCon>().activeated = false;

                 }
             } if (collision.gameObject.tag == "mid_ball")
             {
                 if (m_modeSwitching == ModeSwitching.Start)
                 {
                     m_modeSwitching = ModeSwitching.Force;
                 }
             }
         }
         */


        /* void Swing ()
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

                 case ModeSwitching.Acceleration:
                     MakeCustomForce();
                     m_Rigidbody.AddForce(m_NewForce, ForceMode.Acceleration);
                     break;

                 case ModeSwitching.Force:
                     MakeCustomForce();
                     m_Rigidbody.AddForce(m_NewForce, ForceMode.Force);
                     break;

                 case ModeSwitching.Impulse:
                     MakeCustomForce();
                     m_Rigidbody.AddForce(m_NewForce, ForceMode.Impulse);
                     break;
             }
         }*/

       /* void OnGUI()
    {
        //Getting the inputs from each text field and storing them as strings
        m_ForceXString = GUI.TextField(new Rect(300, 10, 200, 20), m_ForceXString, 25);
        m_ForceYString = GUI.TextField(new Rect(300, 30, 200, 20), m_ForceYString, 25);

        //Press the button to reset the GameObject and Rigidbody
        if (GUI.Button(new Rect(100, 0, 150, 30), "Reset"))
        {
            //This switches to the start/reset case
            m_modeSwitching = ModeSwitching.Start;
        }

        //When you press the Acceleration button, switch to Acceleration mode
        if (GUI.Button(new Rect(100, 30, 150, 30), "Apply Acceleration"))
        {
            //Switch to Acceleration (apply acceleration force to GameObject)
            m_modeSwitching = ModeSwitching.Acceleration;
        }

        //If you press the Impulse button
        if (GUI.Button(new Rect(100, 60, 150, 30), "Apply Impulse"))
        {
            //Switch to impulse (apply impulse forces to GameObject)
            m_modeSwitching = ModeSwitching.Impulse;
        }

        //If you press the Force Button, switch to Force state
        if (GUI.Button(new Rect(100, 90, 150, 30), "Apply Force"))
        {
            //Switch to Force (apply force to GameObject)
            m_modeSwitching = ModeSwitching.Force;
        }

        //Press the button to switch to VelocityChange state
        if (GUI.Button(new Rect(100, 120, 150, 30), "Apply Velocity Change"))
        {
            //Switch to velocity changing
            m_modeSwitching = ModeSwitching.VelocityChange;
        }
    }*/

   /* float ConvertToFloat(string name)
    {
        float.TryParse(name, out m_Result);
        return m_Result;
    }*/
    void MakeCustomForce()
    {
        if (endSwingR.GetComponent<endSwing>().reverse == false)
        {
            m_ForceX = X;
            m_ForceY = Y;
        } else if (endSwingR.GetComponent<endSwing>().reverse == true)
        {
            m_ForceX = X * -1;
            m_ForceY = Y * -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
