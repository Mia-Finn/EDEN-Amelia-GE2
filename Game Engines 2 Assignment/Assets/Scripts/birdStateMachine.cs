using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdStateMachine : MonoBehaviour
{
    //Stuff for state machine
    public GameObject bird, worm, player, idlePos;
    public float speed;

    //Bools for states
    public bool canIdle, canFlee, canChase;

    //State machine
    public enum State { Idle, Flee, Chase };
    private State currentState;

    // Start is called before the first frame update
    void Start()
    {
        //Set start state
        currentState = State.Idle;
    }

    // Update is called once per frame
    void Update()
    {
        boolCheck();

        //state machine
        switch (currentState)
        {
            case State.Idle:

                if (canIdle == true)
                {
                    birdIdle();
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
                    birdFlee();
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
                    birdChase();
                }
                break;
        }
    }

    void boolCheck()
    {
        if(Vector3.Distance(player.transform.position, bird.transform.position) > 5f)
        {
            canIdle = true;
            canFlee = false;
            canChase = false;
        }
        else if(Vector3.Distance(player.transform.position, bird.transform.position) < 5f)
        {
            canIdle = false;
            canFlee = true;
            canChase = false;
        }
        else if(Vector3.Distance(bird.transform.position, worm.transform.position) < 10f && Vector3.Distance(player.transform.position, bird.transform.position) > 5f)
        {
            canIdle = false;
            canFlee = false;
            canChase = true;
        }
    }

    void birdIdle()
    {
        Vector3 firstPos = idlePos.transform.position;
        Vector3 goPos = Vector3.MoveTowards(transform.position, firstPos, speed * Time.deltaTime);
        transform.position = goPos;
        Debug.Log("Idle");
    }

    void birdChase()
    {
        /*
        Vector3 wormPos = worm.transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, wormPos, speed * Time.deltaTime);
        transform.position = newPos;
        */
        Debug.Log("Chase");
    }

    void birdFlee()
    {
        Vector3 fleePos = bird.transform.position - player.transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, fleePos, speed * Time.deltaTime);
        transform.position = newPos;
        Debug.Log("Flee");
    }
}
