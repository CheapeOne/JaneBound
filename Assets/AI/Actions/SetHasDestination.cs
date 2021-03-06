
/*
 * SetHasDestination.cs
 * Rain AI action, toggels whether the AI has a destination or not (if they're chasing the player or not).
 * If the NPC has no destination, they go back to patrolling.
 */

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

#region Chris

[RAINAction]
public class SetHasDestination : RAINAction
{
    public override void Start(RAIN.Core.AI ai)
    {
		//Debug.Log ("start chasing");
		bool myHasDestination = ai.WorkingMemory.GetItem<bool>("hasDestination");
		ai.WorkingMemory.SetItem<bool>("hasDestination", !myHasDestination);
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