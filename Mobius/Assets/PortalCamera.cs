using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Camera portalCamera;
    public Camera playerCamera;

    public PairedPortal portal1;
    public PairedPortal portal2;

    // Update is called once per frame
    void Update()
    {
        Matrix4x4 portalMatrix = portal1.transform.localToWorldMatrix * portal2.transform.worldToLocalMatrix * playerCamera.transform.localToWorldMatrix;

        portalCamera.transform.SetPositionAndRotation(portalMatrix.GetColumn(3), portalMatrix.rotation);
    }
}
