using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSystem : MonoBehaviour
{
    private Trigger trigger = null;
    private GrabbableTrigger grabbable;
    public Hands hands;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            triggerObject();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Trigger nextTrigger = other.gameObject.GetComponent<Trigger>();
        if (nextTrigger != null && hands.grabbableObject == null)
        {
            trigger = other.gameObject.GetComponent<Trigger>();
            //Debug.Log("Entering Trigger: " + nextTrigger);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Trigger nextTrigger = other.gameObject.GetComponent<Trigger>();
        if (nextTrigger == trigger && trigger != null && hands.grabbableObject == null)
        {
            //Debug.Log("Exiting trigger: " + nextTrigger);
            trigger = null;
        }
    }

    public void triggerObject()
    {
        Debug.Log("Attempting to trigger: " + trigger);
        if (trigger != null)
        {
            trigger.trigger(this);
        }
    }
}
