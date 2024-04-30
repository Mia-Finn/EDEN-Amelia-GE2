using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        /*
        else
        {
            cursorOff();
        }
        */
    }

    public void cursorOff()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
