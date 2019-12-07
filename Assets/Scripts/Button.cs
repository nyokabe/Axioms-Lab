using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    [RequireComponent(typeof(Collider))] //A collider is needed to receive clicks
    public class Interact : MonoBehaviour
    {
        public UnityEvent interactEvent;
        private void OnMouseDown()
        {
            interactEvent.Invoke();
            Debug.Log("hi");
        }
    }
}
