using UnityEngine;
using System.Collections;

public class FighterAnimationDemoFREE : MonoBehaviour {
	
	public Animator animator;

	private Transform defaultCamTransform;
	private Vector3 resetPos;
	private Quaternion resetRot;
	private GameObject cam;
	private GameObject fighter;

	void Start()
	{
		cam = GameObject.FindWithTag("MainCamera");
		defaultCamTransform = cam.transform;
		resetPos = defaultCamTransform.position;
		resetRot = defaultCamTransform.rotation;
		fighter = GameObject.FindWithTag("Player");
		fighter.transform.position = new Vector3(0,0,0);
	}

	void OnGUI () 
	{

		if (GUI.RepeatButton (new Rect (200, 575, 50, 50), "->")) 
		{
			animator.SetBool("Walk Forward", true);
		}
		else
		{
			animator.SetBool("Walk Forward", false);
		}

		if (GUI.RepeatButton (new Rect (125, 575, 50, 50), "<-")) 
		{
			animator.SetBool("Walk Backward", true);
		}
		else
		{
			animator.SetBool("Walk Backward", false);
		}

		if (GUI.Button (new Rect (800, 575, 50, 50), "Punch")) 
		{
			animator.SetTrigger("PunchTrigger");
		}
	}
}