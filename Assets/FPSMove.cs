﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : MonoBehaviour {

    //Rigidbody2D rb;
    //public float DodgeBkForce;
    //public float DodgeFwForce;
    public float mSpeed;
	// Use this for initialization
	void Start ()
    {
        //rb = GetComponent<Rigidbody2D>();
		mSpeed = 4f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //mSpeed * Input.GetAxis ("Vertical") * Time.deltaTime
		transform.Translate(mSpeed * Input.GetAxis ("Vertical") * Time.deltaTime, 0f, mSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime);
	}
    /*
    void DodgeBk()
    {
        rb.AddForce(new Vector2(DodgeBkForce, 0));
    }

    void DodgeFw()
    {
        rb.AddForce(new Vector2(DodgeFwForce, 0));
    }

    void Punch()
    {

    }

    void Kick()
    {

    }
    */
}