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
     //   Debug.Log("Summer Loaded!");
    }

    //switcch to spring scene
    public void springScene()
    {
        SceneManager.LoadScene("Spring scene");
     //   Debug.Log("Spring Loaded!");
    }

    //switch to winter scene
    public void winterScene()
    {
        SceneManager.LoadScene("Winter scene");
      //  Debug.Log("Winter Loaded!");
    }

    //switch to autumn scene
    public void autumnScene()
    {
        SceneManager.LoadScene("Autumn scene");
      //  Debug.Log("Autumn Loaded!");
    }

    //Exit game
    public void exitGame()
    {
        Application.Quit();
        Debug.Log("QUIT GAME!");
    }

}
