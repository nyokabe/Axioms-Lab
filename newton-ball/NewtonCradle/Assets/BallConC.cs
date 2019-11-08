using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallConC : MonoBehaviour
{
    //force mode
    enum ModeSwitch { Start, Force};
    ModeSwitch ModeS;
    Vector3 StartPos, StartForce;
    Vector3 NForce;
   //public string ZFString = string.Empty;
   //public string YFString = string.Empty;
    public float ZF, YF;
    float result;
    //game objects
    //public GameObject endSwingR;
    //public GameObject StartB;
    //public GameObject stoper;
    public Rigidbody rb;
    //trial bools
    public bool reset = false;
    public bool FR = false;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ModeS = ModeSwitch.Start;
        NForce = new Vector3(0f, 1.0f, 5.0f);
        ZF = 0f;
        YF = 0f;
       // ZFString = "0";
       // YFString = "0";
        StartPos = transform.position;
        StartForce = rb.transform.position;
    }


    void FixedUpdate()
    {
        //if the current mode is not starting or reset the force can change
        if (ModeS != ModeSwitch.Start)
        {
            NForce = new Vector3(0f, YF, ZF);
        }

        switch (ModeS)
        {
            //resets game object
            case ModeSwitch.Start:
                //resets game object and rigidbody
                transform.position = StartPos;
                rb.transform.position = StartForce;
                //resets celocity
                rb.velocity = new Vector3(0f, 0f, 0f);
                break;
           
            /*case ModeSwitch.Acceleration:
                //MakeForce();
                rb.AddForce(NForce, ForceMode.Acceleration);
                break;*/
            //force mode continuous force that considers the mass probably the most usefull for this
            case ModeSwitch.Force:
               // MakeForce();

               //applys force on gameobjects rigidbody
                rb.AddForce(NForce, ForceMode.Force);
                break;
            //impulse uses mass to apply instant force
            /*case ModeSwitch.Impulse:
              //  MakeForce();
              //applys force
                rb.AddForce(NForce, ForceMode.Impulse);
                break;
            case ModeSwitch.VelocityChange:
              //  MakeForce();
                rb.AddForce(NForce, ForceMode.VelocityChange);
                break;*/
        }
        //reverse the swing when it collides with the box collider
        /* if (end == true)
         {
           // NForce = new Vector3 (0f, (YF * -1), (ZF * -1));
         }
         // begins the swing when the start buttion is used functional
         if (StartB.GetComponent<buttionCon>().activeated == true)
         {
             //swinging();
         }
         //stops the swinging when it hits the next ball
         if (stop == true)
         {
             NForce = new Vector3(0f, 0f, 0f);
         }*/
    }

    //part of api 
    /*private void OnGUI()
    {
        YFString = GUI.TextField(new Rect(300, 10, 200, 20), YFString, 25);

    }*/

    //test movement
    void move() 
    { 
        if (reset == true)
        {
            ModeS = ModeSwitch.Start;
        }
        /*if(accel == true){
            ModeS = ModeSwitch.Acceleration;
        }*/
       /* if (impu == true)
        {
            ModeS = ModeSwitch.Impulse;
        }*/
        if (FR == true)
        {
            ModeS = ModeSwitch.Force;
        }
      /*  if (VC == true)
        {
            ModeS = ModeSwitch.VelocityChange;
        }*/
    }
    //probably not needed
    /*
    float ConvertToFloat(string Name)
    {
        float.TryParse(Name, out result);
        return result;
    }*/

   /* void MakeForce()
    {
        YF = ConvertToFloat(YFString);
        ZF = ConvertToFloat(ZFString);
    }*/

    /*private void OnCollisionEnter(Collision collision)
     //sets the bool at collision for the end and stop
    {
        if (collision.gameObject == endSwingR)
        {
            end = true;
        }

        if (collision.gameObject == stoper)
        {
            stop = true;
        }
    }*/

    //begins the swing
   /* void swinging()
    {
        rb.velocity = new Vector3(0f, 0f, .25f);
        rb.AddForce(rb.velocity, ForceMode.Force);
    }*/
    // Update is called once per frame
    void Update()
    {

      
    }
}
