﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour {
	public enum PlayerType{
		HUMAN, AI
	};
	public static float MAX_HEALTH = 100f;

	public float health = MAX_HEALTH;
	public string fighterName;
	public Fighter opponent;
	public PlayerType player;

	protected Animator animator;
	private Rigidbody myBody;

	// Use this for initialization
	void Start () {
		myBody = GetComponent<Rigidbody>();
		animator = GetComponent<Animator>();
		
	}

	//These are purely for testing, since we have no swipe controls
	//I have set up keyboard controls in order to make sure hitboxes 
	//and movement work properly
	///*
	public void UpdateHumanInput (){
		if (Input.GetKeyDown (KeyCode.D)){
			animator.SetTrigger("DodgeFdTrigger");
		}
		if (Input.GetKeyDown (KeyCode.A)){
			animator.SetTrigger("DodgeBkTrigger");
		}
		if (Input.GetKeyDown (KeyCode.P)){
			animator.SetTrigger("PunchTrigger");
		}
		if (Input.GetKeyDown (KeyCode.K)){
			animator.SetTrigger("KickTrigger");
		}
		if (Input.GetKeyDown (KeyCode.B)){
			animator.SetTrigger("Bock");
		}
	}
	//*/
	// Update is called once per frame
	void Update () {
		animator.SetFloat ("health", currentHealth);

		if (opponent != null){
			animator.SetFloat ("opponent_health", opponent.currentHealth);
		}
		else{
			animator.SetFloat("opponent_health", 1);
		}
		//This is also associated with the keyboard testing
		///*
			if (player == PlayerType.HUMAN){
					UpdateHumanInput ();
			}
		// */
	}

	public float currentHealth{
		get{
			return health/MAX_HEALTH;
		}
	}

	public Rigidbody body{
		get{
			return this.myBody;
		}
	}
}
