using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PairedPortal : MonoBehaviour
{
    public PairedPortal pairedPortal;
    private PortalPair portalPairParent;

    public void OnTriggerEnter(Collider other)
    {
        Portable portable = other.GetComponent<Portable>();
        if (portalPairParent.cooledDown() && portable != null)
        {
            Debug.Log(other.name + " entering portal: " + name);
            portalPairParent.portalEntered();
            Vector3 positionalDifference = other.transform.position - transform.position;
            Debug.Log(other.transform.position);
            other.transform.position = positionalDifference + pairedPortal.transform.position;
            Debug.Log(other.transform.position);
        }
    }

    public void setPortalPairParent(PortalPair portalPair)
    {
        portalPairParent = portalPair;
    }
}
