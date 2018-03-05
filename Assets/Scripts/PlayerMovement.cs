using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D rb;
    public float DodgeBkForce;
    public float DodgeFwForce;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

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
}
