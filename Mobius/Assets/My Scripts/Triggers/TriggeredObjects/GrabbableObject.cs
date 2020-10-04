using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : TriggeredObject
{
    public override void trigger(TriggerSystem triggerSystem)
    {
        Debug.Log("Grabbing: " + name);
        Hands hands = triggerSystem.hands;
        if (hands == null)
        {
            return;
        }
        hands.grab(this);
    }
}
