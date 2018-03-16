using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{

    public Fighter Player1;
    public Fighter Player2;

    public Text player1Tag;
    public Text player2Tag;

    public Text timerText;

    public Scrollbar leftBar;
    public Scrollbar rightBar;

    public BattleController battle;

	// Use this for initialization
	void Start ()
    {
        player1Tag.text = Player1.fighterName;
        player2Tag.text = Player2.fighterName;
	}
	
	// Update is called once per frame
	void Update ()
    {

        timerText.text = battle.roundTime.ToString();

		if(leftBar.size > Player1.currentHealth)
        {
            leftBar.size -= 0.01f;
        }
        if(rightBar.size > Player2.currentHealth)
        {
            rightBar.size -= 0.01f;
        }
	}
}
