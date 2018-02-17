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

		fighter = GameObject.FindWithTag("Player");
		
	}

	void OnGUI () 
	{


		if (GUI.RepeatButton (new Rect (Screen.width/6, Screen.height - Screen.height/10, Screen.width/16, Screen.height/12), "Walk Forward")) 
		{
			animator.SetBool("Walk Forward", true);
		}
		else
		{
			animator.SetBool("Walk Forward", false);
		}

		if (GUI.RepeatButton (new Rect (Screen.width/12, Screen.height - Screen.height/10, Screen.width / 16, Screen.height / 12), "Walk Backward")) 
		{
			animator.SetBool("Walk Backward", true);
		}
		else
		{
			animator.SetBool("Walk Backward", false);
		}

		if (GUI.Button (new Rect (Screen.width - Screen.width/10, Screen.height - Screen.height/10, Screen.width / 16, Screen.height / 12), "Punch")) 
		{
			animator.SetTrigger("PunchTrigger");
		}
	}
}