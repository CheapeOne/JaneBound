using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

#region Sabrina
[RAINAction]
public class BangAction : RAINAction
{
    public override void Start(RAIN.Core.AI ai)
	{
		Bang bang = GameObject.Instantiate (ai.WorkingMemory.GetItem ("bang") as GameObject).GetComponent<Bang> ();
		float yOffset = ai.Body.GetComponent<CapsuleCollider>().bounds.size.y;
		yOffset += 1.2f;
		Vector3 copPosition = ai.Body.transform.position;
		bang.transform.position = new Vector3 (copPosition.x,
		                                       copPosition.y + yOffset,
		                                       copPosition.z);
		bang.transform.SetParent(ai.Body.transform,true);

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