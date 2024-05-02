using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class wormStateMachine : MonoBehaviour
{
    //Bools for states
    public bool canIdle, canFlee, canChase;

    //State machine
    public enum State { Idle, Flee, Chase };
    private State currentState;

    //Triggers for states
    private GameObject flower;

    // Start is called before the first frame update
    void Start()
    {
        currentState = State.Idle;
        flower = GameObject.FindGameObjectWithTag("Flower");
    }

    // Update is called once per frame
    void Update()
    {
        //state machine
        switch (currentState)
        {
            case State.Idle:

                if (canIdle == true)
                {
                    wormIdle();
                }
                else if (canFlee == true)
                {
                    currentState = State.Flee;
                }
                else if (canChase == true)
                {
                    currentState = State.Chase;
                }

            break;

            case State.Flee:

                if (canIdle == true)
                {
                    currentState = State.Idle;
                }
                else if (canFlee == true)
                {
                    wormFlee();
                }
                else if (canChase == true)
                {
                    currentState = State.Chase;
                }

                break;

            case State.Chase:

                if (canIdle == true)
                {
                    currentState = State.Idle;
                }
                else if (canFlee == true)
                {
                    currentState = State.Flee;
                }
                else if (canChase == true)
                {
                    wormChase();
                }

                break;
        }

        boolControl();
    }

    void wormIdle()
    {
        Debug.Log("Idle");
    }

    void wormFlee()
    {
        Debug.Log("Flee");
    }

    void wormChase()
    {
        Debug.Log("Chase");
    }

    void boolControl()
    {

    }
}
