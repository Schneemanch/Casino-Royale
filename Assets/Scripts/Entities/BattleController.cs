using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleController : MonoBehaviour
{
    public int roundTime = 99;
    private float lastTimeUpdate = 0;

    public HUDController hud;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(roundTime > 0 && Time.time - lastTimeUpdate > 1)
        {
            roundTime--;
            lastTimeUpdate = Time.time;
        }

        //if(roundTime < 90)
        //{
        //    if (hud.leftBar.size < hud.rightBar.size)
        //    {
        //        SceneManager.LoadScene(0);
        //    }
        //}
	}
}
