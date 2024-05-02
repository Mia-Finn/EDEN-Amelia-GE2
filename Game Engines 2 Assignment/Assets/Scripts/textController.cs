using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class textController : MonoBehaviour
{
    //Register the bird the player is looking at
    public LayerMask layerMask;
    public GameObject player; // BB, BT, R, CF, HS, GF;
    private bool isHit, isBB, isBT, isR, isCF, isHS, isGF;
    public TMP_Text typeText, habitatText, factText;
    private GameObject BB, BT, R, CF, HS, GF;

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            isHit = true;
          //  Debug.Log("Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            isHit = false;
         //   Debug.Log("Not Hit");
        }

        //Find gameobjects
        BB = GameObject.FindGameObjectWithTag("BB");
        BT = GameObject.FindGameObjectWithTag("BT");
        R = GameObject.FindGameObjectWithTag("R");
        CF = GameObject.FindGameObjectWithTag("CF");
        HS = GameObject.FindGameObjectWithTag("HS");
        GF = GameObject.FindGameObjectWithTag("GF");

        //Check which bird
        isBB = Vector3.Distance(player.transform.position, BB.transform.position) < 3f; //Blackbird
        isBT = Vector3.Distance(player.transform.position, BT.transform.position) < 3f; //Blue tit
        isR = Vector3.Distance(player.transform.position, R.transform.position) < 3f; //Robin
        isCF = Vector3.Distance(player.transform.position, CF.transform.position) < 3f; //Chaffinch
        isHS = Vector3.Distance(player.transform.position, HS.transform.position) < 3f; //House Sparrow
        isGF = Vector3.Distance(player.transform.position, GF.transform.position) < 3f; //Goldfinch

        //Text
        birdInfo();
    }

    void birdInfo()
    {
        //Blackbird
        if(isHit == true && isBB)
        {
            typeText.text = "Bird Type = Blackbird";
            habitatText.text = "Habitat = Gardens & Farmland";
            factText.text = "Males are black with orange beaks, females are brown";
        }
        //Blue tit
        else if (isHit == true && isBT)
        {
            typeText.text = "Bird Type = Blue tit";
            habitatText.text = "Habitat = Gardens & Farmland";
            factText.text = "Fun Fact = Considered a European bird even though they are found in most of the world";
        }
    }
}
