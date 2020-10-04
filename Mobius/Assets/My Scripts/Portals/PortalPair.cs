using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalPair : MonoBehaviour
{
    public static float PORTAL_COOLDOWN = 0.1f;

    public PairedPortal portal1;
    public PairedPortal portal2;

    private float portalCooldown = 0;

    public void Awake()
    {
        portal1.pairedPortal = portal2;
        portal2.pairedPortal = portal1;
        portal1.setPortalPairParent(this);
        portal2.setPortalPairParent(this);
        portalCooldown = 0;
    }

    public void Update()
    {
        portalCooldown -= Time.deltaTime;
        if (portalCooldown <= 0)
        {
            portalCooldown = 0;
        }
    }

    public bool cooledDown()
    {
        return portalCooldown <= 0;
    }

    public void portalEntered()
    {
        portalCooldown = PORTAL_COOLDOWN;
    }
}
