using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDropAct : MonoBehaviour
{
    public GameObject Green_botton;
    public bool ButtonIsDown;
    public bool triggerClicked;
    public GameObject LabInsides;

    void Start()
    {
      ButtonIsDown = false;
      triggerClicked = false;
      LabInsides.GetComponent<MainControl>();
    }
    void Update()
    {
       
        if (ButtonIsDown == true)
        {
            LabInsides.GetComponent<MainControl>().SetLevelBallDropActive();
            ButtonIsDown = false;
        }
        if (triggerClicked == true)
        {
            LabInsides.GetComponent<MainControl>().SetLevelBallDropActive();
            triggerClicked = false;
        }

    }
     void OnMouseDown()
    {
        ButtonIsDown = true;

    }
    void OnTriggerClicked()
    {
        triggerClicked = true;
    }

}
