using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleController : MonoBehaviour
{
    public int roundTime = 99;
    private float lastTimeUpdate = 0;

    public HUDController hud;

    public Fighter player1;
    public Fighter player2;

    public AudioSource musicPlayer;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public AudioClip backgroundMusic;
    private bool battleStarted;

    public float delayTime;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!battleStarted)
        {
            battleStarted = true;

            //player1.enable = true;
            //player2.enable = true;

            GameUtils.playSound(backgroundMusic, musicPlayer);
        }


        if (roundTime > 0 && Time.time - lastTimeUpdate > 1)
        {
            roundTime--;
            lastTimeUpdate = Time.time;
        }

        if (player1.health <= 0)
        {

            Invoke("YouLose", delayTime);

        }
        else if (player2.health <= 0)
        {

            PlayWinClip();
            GameUtils.playSound(audioClip, audioSource);
            Invoke("YouWin", delayTime);


        }

        //if(roundTime < 90)
        //{
        //    if (hud.leftBar.size < hud.rightBar.size)
        //    {
        //        SceneManager.LoadScene(0);
        //    }
        //}
    }


    void YouWin()
    {
        SceneManager.LoadScene("You Win");
    }

    void YouLose()
    {
        SceneManager.LoadScene("You Lose");
    }

    public void PlayWinClip()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
