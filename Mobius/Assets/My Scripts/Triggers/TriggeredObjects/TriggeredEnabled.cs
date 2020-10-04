using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredEnabled : TriggeredObject
{
    public bool enableOnly = true;

    public override void trigger(TriggerSystem triggerSystem)
    {
        base.trigger(triggerSystem);
        
    }
}
