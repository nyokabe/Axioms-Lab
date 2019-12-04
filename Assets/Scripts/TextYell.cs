using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextYell : MonoBehaviour
{
    public Button_Control button;//refrence to button
    void Update()
    {
        if (button.Pressed == true)
        {
            Debug.Log ("You did a thing");
        }
    }
}
