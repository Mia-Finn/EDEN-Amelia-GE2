using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitch : MonoBehaviour
{
    //switch to the summer scene
    public void summerScene()
    {
        SceneManager.LoadScene("Summer scene");
    }

    //switcch to spring scene
    public void springScene()
    {
        SceneManager.LoadScene("Spring scene");
    }

    //switch to winter scene
    public void winterScene()
    {
        SceneManager.LoadScene("Winter scene");
    }

    //switch to autumn scene
    public void autumnScene()
    {
        SceneManager.LoadScene("Autumn scene");
    }

    //Exit game
    public void exitGame()
    {
        Application.Quit();
        Debug.Log("QUIT GAME!");
    }

}
