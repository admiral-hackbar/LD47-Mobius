using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredAudio : TriggeredObject
{
    AudioSource auidoData;
    
    void Start()
    {
        auidoData = GetComponent<AudioSource>();
    }

    public override void trigger(TriggerSystem triggerSystem)
    {
        if (triggerOnceOnly && triggeredOnce)
        {
            return;
        }

        auidoData.Play(0);

        base.trigger(triggerSystem);
    }
}
