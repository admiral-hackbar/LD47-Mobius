using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterForFPSController : Teleporter
{
    public FPSController controller;

    void Update()
    {
        updateSpotForFPSController();
    }

    private void updateSpotForFPSController()
    {
        if (controller == null)
        {
            return;
        }

        spot.transform.position = controller.SnapPosition(spot.transform.position);
    }
}
