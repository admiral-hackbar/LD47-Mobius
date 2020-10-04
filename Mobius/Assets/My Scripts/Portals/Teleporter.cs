using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : Trigger
{
    public GameObject spot;

    public void OnTriggerEnter(Collider other)
    {
        PortalTraveller traveller = other.GetComponent<PortalTraveller>();
        if (traveller != null)
        {
            traveller.Teleport(transform, spot.transform, (spot.transform.localToWorldMatrix * transform.worldToLocalMatrix).GetColumn(3), other.transform.rotation);
            trigger(null);
        }
        
    }
}
