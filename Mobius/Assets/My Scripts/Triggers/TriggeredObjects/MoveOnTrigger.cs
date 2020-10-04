using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnTrigger : TriggeredObject
{
    public Vector3[] places;
    public float speed = 5;
    public bool loop = true; // If true: will go to first position after last. If false: will return backwards.
    // TODO, may not do the latter

    private int currentPlace = 0;

    public void Start()
    {
        this.currentPlace = 0;
        transform.localPosition = places[currentPlace];
    }

    public void Update()
    {
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, places[currentPlace], step);
    }

    public override void trigger(TriggerSystem triggerSystem)
    {
        currentPlace += 1;
        if (currentPlace >= places.Length)
        {
            currentPlace = 0;
        }
        Debug.Log("Triggered to move. Next place: " + currentPlace + " at " + places[currentPlace]);
    }
}
