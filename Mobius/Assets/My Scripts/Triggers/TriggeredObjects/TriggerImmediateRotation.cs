using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerImmediateRotation : TriggeredObject
{
    public Vector3 mask;
    public float rotation = 180;

    public override void trigger(TriggerSystem triggerSystem)
    {
        if (!triggeredOnce)
        {
            transform.eulerAngles = transform.eulerAngles + rotation * mask;
        }
        base.trigger(triggerSystem);
    }
}
