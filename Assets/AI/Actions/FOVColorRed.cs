
/*
 * FOVColorRed.cs
 * Rain AI action, executed to change the NPCs FOV to ALERT color.
 */

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

#region Chris

[RAINAction]
public class FOVColorRed : RAINAction
{
    public override void Start(RAIN.Core.AI ai)
    {
		//Change the FOV Color
		FOV2DVisionCone FOV = ai.Body.transform.Find("FOV2D").GetComponent<FOV2DVisionCone>();
		FOV.status = FOV2DVisionCone.Status.Alert;
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}

#endregion