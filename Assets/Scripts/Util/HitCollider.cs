using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCollider : MonoBehaviour {
	public string punchName;
	public float damage;
	public Fighter owner;

	void OnTriggerEnter(Collider other){
		Fighter somebody = other.gameObject.GetComponent<Fighter> ();

		if (somebody != null && somebody != owner){
			//Debug.Log ("I hit " + somebody + " with " + punchName);
			somebody.hurt(damage);
		}
	}
}
