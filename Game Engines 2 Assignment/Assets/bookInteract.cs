using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookInteract : MonoBehaviour
{

    public GameObject player, bookInfo, birdText;

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.E) && Vector3.Distance(player.transform.position, gameObject.transform.position) < 3f)
        {
            bookInfo.SetActive(true);
            birdText.SetActive(false);
          //  Debug.Log("E pressed!");
        }
    }
}
