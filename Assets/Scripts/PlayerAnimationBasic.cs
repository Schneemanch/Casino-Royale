using System.Collections;
using System.Collections.Generic;
using UnityEngine;





//public class PlayerAnimationBasic : MonoBehaviour
//{

//    #region Attributes

//    private Animator animator;

//    private const string IDLE_ANIMATION_BOOL = "Idle";
//    private const string WALKFORWARD_ANIMATION_BOOL = "WalkForward";
//    private const string WALKBACKWARD_ANIMATION_BOOL = "WalkBackward";
//    private const string PUNCH_ANIMATION_BOOL = "Punch";

//    #endregion

//    #region Animation Functions

//    public void AnimateIdle()
//    {
//        //Animate(IDLE_ANIMATION_BOOL);
//        animator.SetBool("WalkForward", true);
//    }

//    public void AnimateWalkForeward()
//    {
//        Animate(WALKFORWARD_ANIMATION_BOOL);
//    }

//    public void AnimateWalkBackward()
//    {
//        Animate(WALKBACKWARD_ANIMATION_BOOL);
//    }

//    public void AnimatePunch()
//    {
//        Animate(PUNCH_ANIMATION_BOOL);
//    }



//    #endregion

//    private void Start()
//    {
//        animator = GetComponent<Animator>();

//    }

//    private void Animate(string boolName)
//    {
//        DisableOtherAnimations(animator, boolName);

//        animator.SetBool(boolName, true);
//    }

//    private void DisableOtherAnimations(Animator animator, string animation)
//    {
//        foreach (AnimatorControllerParameter parameter in animator.parameters)
//        {
//            if (parameter.name != animation)
//            {
//                animator.SetBool(parameter.name, false);
//            }
//        }
//    }








//}


public class PlayerAnimationBasic : MonoBehaviour
{

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

    public void AnimateWalkForeward()
    {
        animator.SetBool("Walk Forward", true);
    }

    void OnGUI()
    {


        if (GUI.RepeatButton(new Rect(Screen.width / 8, ((Screen.height / 2) / 2) / 2, 115, 115), "Walk Forward"))
        {
            animator.SetBool("Walk Forward", true);
        }
        else
        {
            animator.SetBool("Walk Forward", false);
        }

        if (GUI.RepeatButton(new Rect(Screen.width / 2 - 900, Screen.height / 2 + 418, 115, 115), "Walk Backward"))
        {
            animator.SetBool("Walk Backward", true);
        }
        else
        {
            animator.SetBool("Walk Backward", false);
        }

        if (GUI.Button(new Rect(Screen.width / 2 + 800, Screen.height / 2 + 418, 115, 115), "Punch"))
        {
            animator.SetTrigger("PunchTrigger");
        }
    }
}
