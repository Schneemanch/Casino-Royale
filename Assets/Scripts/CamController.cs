using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour {
	public Transform leftTarget;
	public Transform rightTarget;

	public float minDistance;
	public float maxDistance = 5;
	
	//Runs every frame just like update, but it runs after all other items run for update
	//Thus camera in sure to move AFTER character has moved

	void LateUpdate () {
		float distanceBetweenTargets = Mathf.Abs (leftTarget.position.x - rightTarget.position.x);
		float centerPosition = (leftTarget.position.x + rightTarget.position.x)/2;

		transform.position = new Vector3 (
			centerPosition, transform.position.y,
			distanceBetweenTargets < maxDistance? + distanceBetweenTargets: + maxDistance
		);
		
		//transform.position = Male.transform.position + offset;
	}
}
