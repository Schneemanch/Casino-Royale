using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour {
    
    public float mSpeed;
    public Animator animator;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {

        // Sort of works? Whyyyy :(
        if (animator.GetBool("DodgeFd"))
        {
            transform.Translate(0f, 0f, mSpeed * Time.deltaTime);
        } else {

        }
        if (animator.GetBool("DodgeBk"))
        {
            transform.Translate(0f, 0f, -mSpeed * Time.deltaTime);
        }
    }
}
