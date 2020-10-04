using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredLight : TriggeredObject
{
    public Material offMaterial;
    public Material onMaterial;

    private bool on;

    public override void trigger(TriggerSystem triggerSystem)
    {
        on = !on;
        Renderer renderer = gameObject.GetComponent<Renderer>();
        if (renderer != null)
        {
            if (on)
            {
                renderer.material = onMaterial;
            } else
            {
                renderer.material = offMaterial;
            }
        }
    }
}
