using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class textController : MonoBehaviour
{
    public GameObject player, BB, BT, R, CF, HS, GF, S, Book;
    public TMP_Text typeText, habitatText, factText, interactText;
    private bool isBB, isBT, isR, isCF, isHS, isGF, isS, isBook;
    // public string None;

    private void Update()
    {
        //Check distance from bird
        isBB = Vector3.Distance(player.transform.position, BB.transform.position) < 3f; //Blackbird
        isBT = Vector3.Distance(player.transform.position, BT.transform.position) < 3f; //Blue tit
        isR = Vector3.Distance(player.transform.position, R.transform.position) < 3f; //Robin
        isCF = Vector3.Distance(player.transform.position, CF.transform.position) < 3f; //Chaffinch
        isHS = Vector3.Distance(player.transform.position, HS.transform.position) < 3f; //House Sparrow
        isGF = Vector3.Distance(player.transform.position, GF.transform.position) < 3f; //Goldfinch
        isS = Vector3.Distance(player.transform.position, S.transform.position) < 3f; //Starling
        isBook = Vector3.Distance(player.transform.position, Book.transform.position) < 3f; //Book menu open

        if (isBT)
        {
            typeText.text = "Bird Type: Blue tit";
            habitatText.text = "Habitat: Gardens & Farmland";
            factText.text = "Fun Fact: Considered a European bird even though they are found in most of the world";
            interactText.text = " ";
        }
        else if(isBB)
        {
            typeText.text = "Bird Type: Blackbird";
            habitatText.text = "Habitat: Gardens & Farmland";
            factText.text = "Fun Fact: Males are black with orange beaks, females are brown";
            interactText.text = " ";
        }
        else if (isR)
        {
            typeText.text = "Bird Type: Robin";
            habitatText.text = "Habitat: Gardens & Farmland";
            factText.text = "Fun Fact: Robins are very territorial and will defend their land with their lives";
            interactText.text = " ";
        }
        else if (isCF)
        {
            typeText.text = "Bird Type: Chaffinch";
            habitatText.text = "Habitat: Gardens & Farmland";
            factText.text = "Fun Fact: These birds have been found to have regional accents depending on the country they live in";
            interactText.text = " ";
        }
        else if (isHS)
        {
            typeText.text = "Bird Type: House Sparrow";
            habitatText.text = "Habitat: Gardens & Farmland";
            factText.text = "Fun Fact: House Sparrows won't migrate in winter, they will just move to the countryside to feed on grain during the autumn harvest";
            interactText.text = " ";
        }
        else if (isGF)
        {
            typeText.text = "Bird Type: Goldfinch";
            habitatText.text = "Habitat: Gardens & Farmland";
            factText.text = "Fun Fact: Many Goldfinches migrate in the Winter";
            interactText.text = " ";
        }
        else if (isS)
        {
            typeText.text = "Bird Type: Starling";
            habitatText.text = "Habitat: Gardens & Farmland";
            factText.text = "Fun Fact: Starlings have the ability to mimic other bird calls or even machine noises";
            interactText.text = " ";
        }
        else if (isBook)
        {
            typeText.text = " ";
            habitatText.text = " ";
            factText.text = " ";
            interactText.text = "Press 'E' to interact!";
        }
        else if(!isGF && !isCF && !isBT && !isBB && !isHS && !isR && !isS && !isBook)
        {
            typeText.text = " ";
            habitatText.text = " ";
            factText.text = " ";
            interactText.text = " ";
        }
    }
}

//Old script
/*
//Register the bird the player is looking at
// public LayerMask layerMask;
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
    isBT = Vector3.Distance(player.transform.position, BT.transform.position) < 5f; //Blue tit
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
    if(isBB)
    {
        typeText.text = "Bird Type = Blackbird";
        habitatText.text = "Habitat = Gardens & Farmland";
        factText.text = "Males are black with orange beaks, females are brown";
    }
    //Blue tit
    else if (isBT)
    {
        typeText.text = "Bird Type = Blue tit";
        habitatText.text = "Habitat = Gardens & Farmland";
        factText.text = "Fun Fact = Considered a European bird even though they are found in most of the world";
    }
    //Goldfinch
    else if (isGF)
    {
        typeText.text = "Bird Type = Goldfinch";
        habitatText.text = "Habitat = Gardens & Farmland";
        factText.text = "Fun Fact = Many Goldfincches migrate in the Winter";
    }
}
*/