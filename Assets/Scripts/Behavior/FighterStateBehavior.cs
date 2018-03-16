using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterStateBehavior : StateMachineBehaviour {

	public AudioClip soundEffect;

	public float horizontalForce;
	public float verticalForce;
	public float testForce;

	protected Fighter fighter;

	// Use this for initialization
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
			if (fighter == null) {
				fighter = animator.gameObject.GetComponent<Fighter> ();
			}

			if (soundEffect != null){
				fighter.playSound(soundEffect);
			}
			fighter.body.AddRelativeForce (new Vector3 (0, verticalForce, 0));
		}
	
	// Update is called once per frame
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
			fighter.body.AddRelativeForce (new Vector3 (0, 0, horizontalForce));
			//fighter.body.AddRelativeForce (new Vector3 (testForce, 0, 0));
			//fighter.body.AddRelativeForce (new Vector3 (0, verticalForce, 0));
		}
}
