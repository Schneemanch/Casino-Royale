using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public void PlayGame()
    {
        //go to character select screen
        SceneManager.LoadScene(3);
    }

    public void BackToMenu()
    {
        //go back to the main menu
        SceneManager.LoadScene(2);
    }

    public void OptionsMenu()
    {
        //go to the options menu
        SceneManager.LoadScene(4);
    }

    public void CharacterSelect()
    {
        //go to the first stage after selecting a character
        SceneManager.LoadScene(5);
    }

    public void QuitGame()
    {

    }


}
