using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredEnableAndDisableObjects : TriggeredObject
{
    public List<GameObject> enableObjects = new List<GameObject>();
    public List<GameObject> disableObjects = new List<GameObject>();
    
    void Awake()
    {
        triggerOnceOnly = false;
    }

    public override void trigger(TriggerSystem triggerSystem)
    {
        if (!triggeredOnce)
        {
            foreach (GameObject disableObject in disableObjects)
            {
                disableObject.SetActive(false);
            }
            foreach (GameObject enableObject in enableObjects)
            {
                enableObject.SetActive(true);
            }
        }
        base.trigger(triggerSystem);
    }
}
