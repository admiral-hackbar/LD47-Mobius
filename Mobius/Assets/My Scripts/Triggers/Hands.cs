using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hands : MonoBehaviour
{
    public GrabbableObject grabbableObject;
    private bool rigidbodyHadGravity;
    private int grabbableLayer;
    private bool grabbableIsTrigger;
    private Transform grabbableParent;

    public void grab(GrabbableObject grabbableObject)
    {
        if (grabbableObject != this.grabbableObject && this.grabbableObject == null)
        {
            this.grabbableObject = grabbableObject;
            grabbableObject.transform.position = transform.position;
            Rigidbody grabbableRigidbody = grabbableObject.gameObject.GetComponent<Rigidbody>();
            Collider grabbableCollider = grabbableObject.gameObject.GetComponent<Collider>();
            rigidbodyHadGravity = grabbableRigidbody.useGravity;
            grabbableRigidbody.useGravity = false;
            grabbableIsTrigger = grabbableCollider.isTrigger;
            grabbableCollider.isTrigger = true;
            grabbableLayer = grabbableObject.gameObject.layer;
            grabbableObject.gameObject.layer = 9; // Layer 9 is the hands layer
            grabbableParent = grabbableObject.transform.parent;
            grabbableObject.transform.parent = transform;
        }
        else if (grabbableObject == this.grabbableObject)
        {
            this.grabbableObject = null;
            Rigidbody grabbableRigidbody = grabbableObject.gameObject.GetComponent<Rigidbody>();
            Collider grabbableCollider = grabbableObject.gameObject.GetComponent<Collider>();
            grabbableRigidbody.useGravity = rigidbodyHadGravity;
            grabbableCollider.isTrigger = grabbableIsTrigger;
            grabbableObject.gameObject.layer = grabbableLayer;
            grabbableObject.transform.parent = grabbableParent;
        }
    }
}
