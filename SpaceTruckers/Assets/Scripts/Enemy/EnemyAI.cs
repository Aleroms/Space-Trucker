using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyAI : MonoBehaviour
{
	public AIPath aipath;
	public Transform target;
	
	public float boundary = 8;
	// Update is called once per frame
	void Update()
	{
		float target_x = target.localPosition.x;
		float target_y = target.localPosition.y;

		if (aipath != null)
		{
			if (Mathf.Abs(target_x) < boundary)
			{
				aipath.canMove = true;
			}
			else
				aipath.canMove = false;

		}
		else
			print("AIPath is null in EnemyAI.cs");



		//Debug()
		//prints targets [x,y]
		//print("x:" + target.localPosition.x + "y:" + target.localPosition.y);
		//prints this [x,y]
		//print("*x:" + this.transform.localPosition.x + "*y:" + this.transform.localPosition.y);
	}
}
