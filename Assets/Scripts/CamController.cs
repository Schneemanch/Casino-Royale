using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour {

	public GameObject Male;

	//offset is the difference 
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - Male.transform.position;
	}
	
	//Runs every frame just like update, but it runs after all other items run for update
	//Thus camera in sure to move AFTER character has moved
	void LateUpdate () {
		transform.position = Male.transform.position + offset;
	}
}
