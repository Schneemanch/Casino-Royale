using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeController : MonoBehaviour
{



    public float maxTime;
    public float minSwipeDistance;

    float startTime;
    float endTime;

    Vector3 startPos;
    Vector3 endPos;

    float swipeDistance;
    float swipeTime;





    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                startTime = Time.time;
                startPos = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                endTime = Time.time;
                endPos = touch.position;

                //distance between swipe begin and swipe end
                swipeDistance = (endPos - startPos).magnitude;
                swipeTime = endTime - startTime;

                if (swipeTime < maxTime && swipeDistance > minSwipeDistance)
                {
                    swipe();
                }

            }
        }
    }

    void swipe()
    {
        Vector2 distance = endPos - startPos;
        if (Mathf.Abs(distance.x) > Mathf.Abs(distance.y))
        {
            Debug.Log("Horizontal Swipe");

            //Right swipe character should move forward
            if (distance.x > 0)
            {
                //call animation for moving forward
                
            }
            //Left swipe, character should move backward
            else if (distance.x < 0)
            {
               
                //call animation for dodgeing backwards
                
            }
        }
        else
        {
            //call idle animation
        }

    }
}

