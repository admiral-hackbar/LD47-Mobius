using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public List<TriggeredObject> triggeredObjects = new List<TriggeredObject>();
    public string color = "none";

    public virtual bool trigger(TriggerSystem triggerSystem)
    {
        bool triggered = false;
        foreach (TriggeredObject triggeredObject in triggeredObjects)
        {
            //if (color == triggeredObject.color)
            //{
                triggeredObject.trigger(triggerSystem);
                triggered = true;
            //}
        }
        return triggered;
    }
}
