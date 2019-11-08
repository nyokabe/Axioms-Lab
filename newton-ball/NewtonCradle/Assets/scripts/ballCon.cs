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
    enum ModeSwitching { Start, Impulse, Acceleration, Force, VelocityChange};
    ModeSwitching m_modeSwitching;
    Vector3 m_StartPos, m_StartForce;
    Vector3 m_NewForce;
    Rigidbody m_Rigidbody;

    string m_ForceYString = string.Empty;
    string m_ForceXString = string.Empty;

    float m_ForceY, m_ForceX;
    float m_Result;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_modeSwitching = ModeSwitching.Start;
        m_NewForce = new Vector3(0, 0, 0);
        m_ForceX = 0;
        m_ForceY = 0;
        m_ForceXString = "1";
        m_ForceYString = "1";
        m_StartPos = transform.position;
        m_StartForce = m_Rigidbody.transform.position;

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
    }

    void OnGUI()
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
    }

    float ConvertToFloat(string name)
    {
        float.TryParse(name, out m_Result);
        return m_Result;
    }
    void MakeCustomForce()
    {
        m_ForceX = ConvertToFloat(m_ForceXString);
        m_ForceY = ConvertToFloat(m_ForceYString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
