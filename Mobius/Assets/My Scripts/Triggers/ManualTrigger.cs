using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualTrigger : Trigger
{
    public Animator animator;

    public void Awake()
    {
        
    }

    public override bool trigger(TriggerSystem triggerSystem)
    {
        bool triggered = base.trigger(triggerSystem);
        if (triggered)
        {
            animator.SetBool("On", !animator.GetBool("On"));
        }
        return triggered;
    }
}
