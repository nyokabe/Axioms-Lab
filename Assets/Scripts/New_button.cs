using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class New_button : MonoBehaviour
{
    public GameObject Green_botton;
    public GameObject Cube;
    public Transform Spawnpoint;
    public bool ButtonIsDown;
    public bool triggerClicked;
    void Start()
    {
      ButtonIsDown = false;
        triggerClicked = false;
    }
    void Update()
    {
       
        if (ButtonIsDown == true)
        {
            Instantiate(Cube, Spawnpoint.position, Spawnpoint.rotation);
            ButtonIsDown = false;
        }
        if (triggerClicked == true)
        {
            Instantiate(Cube, Spawnpoint.position, Spawnpoint.rotation);
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
