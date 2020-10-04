using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredObject : MonoBehaviour
{
    public string color = "none";
    public bool triggerOnceOnly = false;
    public bool triggeredOnce = false;

    public virtual void trigger(TriggerSystem triggerSystem)
    {
        triggeredOnce = true;
    }
    
}
