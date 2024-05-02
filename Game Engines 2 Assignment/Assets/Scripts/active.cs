using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active : MonoBehaviour
{
    public GameObject trig, worm;

    // Update is called once per frame
    void Update()
    {
        
        if(trig.activeInHierarchy == true)
        {
            worm.SetActive(true);
            Debug.Log("ON");
        }
        else if(trig.activeInHierarchy == false)
        {
            worm.SetActive(false);
            Debug.Log("OFF");
        }

        /*
        if(Input.GetKeyDown(KeyCode.E))
        {
            worm.SetActive(true);
            Debug.Log("ON");
        }
        */
    }
}
