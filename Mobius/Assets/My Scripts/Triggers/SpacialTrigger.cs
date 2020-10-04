using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacialTrigger : Trigger
{
    private List<TriggeringObject> triggeringObjects;
    private bool lastStateChange = false;

    public void Awake()
    {
        triggeringObjects = new List<TriggeringObject>();
    }

    private void OnTriggerEnter(Collider other)
    {
        TriggeringObject triggeringObject = other.GetComponent<TriggeringObject>();
        if (triggeringObject != null && triggeringObject.color == color && !triggeringObjects.Contains(triggeringObject))
        {
            triggeringObjects.Add(triggeringObject);
            triggerIfStateChanged();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        TriggeringObject triggeringObject = other.GetComponent<TriggeringObject>();
        if (triggeringObject != null && triggeringObject.color == color && triggeringObjects.Contains(triggeringObject))
        {
            triggeringObjects.Remove(triggeringObject);
            triggerIfStateChanged();
        }
    }

    private void triggerIfStateChanged()
    {
        bool nextStateChange = true;
        if (triggeringObjects.Count <= 0)
        {
            nextStateChange = false;
        }
        if (nextStateChange != lastStateChange)
        {
            lastStateChange = nextStateChange;
            trigger(null);
        }
    }
}
