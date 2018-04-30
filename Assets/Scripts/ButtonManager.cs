using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public float delayTime = 1.5f;
    public float delayTime2 = 1f;

    public void PlayGame()
    {
        //Play the first stage
        //SceneManager.LoadScene("Casino Floor Level");
        Invoke("CharChosen", delayTime2);
    }

    public void BackToMenu()
    {
        //go back to the main menu
        SceneManager.LoadScene("MainMenu");
    }

    public void OptionsMenu()
    {
        //go to the options menu
        SceneManager.LoadScene("Options_Menu");
    }

    public void CharacterSelect()
    {
        //Go to the character select screen
        //SceneManager.LoadScene("Character_Select_Screen");
        Invoke("CharSel", delayTime);
    }

    public void YouLose()
    {
        SceneManager.LoadScene("You Lose");
    }

    public void YouWin()
    {
        SceneManager.LoadScene("You Win");
    }

    void CharSel()
    {
        SceneManager.LoadScene("Character_Select_Screen");

    }

    void CharChosen()
    {
        SceneManager.LoadScene("Casino Floor Level");
    }
}
