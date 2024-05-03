using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaseBirdStateMachine : MonoBehaviour
{
    //Stuff for state machine
    public GameObject bird, worm, player, idlePos;
    public float speed;

    //Bools for states
    public bool canIdle, canChase;

    //State machine
    public enum State { Idle, Chase };
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

       /*
        if(Vector3.Distance(worm.transform.position, bird.transform.position) < 30f)
        {
            birdChase();
        }
        */
        
        //state machine
        switch (currentState)
        {
            case State.Idle:

                if (canIdle == true)
                {
                    birdIdle();
                }
                else if (canChase == true)
                {
                    currentState = State.Chase;
                }
                break;

            case State.Chase:

                if (canChase == true)
                {
                    birdChase();
                }
                else if (canIdle == true)
                {
                    currentState = State.Idle;
                }
                break;
        }
        
    }

    void boolCheck()
    {
        if (Vector3.Distance(worm.transform.position, bird.transform.position) < 5f)
        {
            canIdle = false;
            canChase = true;
        }
        else
        {
            canIdle = true;
            canChase = false;
        }
    }

    void birdIdle()
    {
        Vector3 firstPos = idlePos.transform.position;
        Vector3 goPos = Vector3.MoveTowards(transform.position, firstPos, speed * Time.deltaTime);
        transform.position = goPos;

        //rotate movement direction
        //  bird.transform.rotation = Quaternion.Slerp(bird.transform.rotation, Quaternion.LookRotation(goPos), Time.deltaTime * 40f);

        Debug.Log("Idle");
    }

    void birdChase()
    {
        
        Vector3 wormPos = worm.transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, wormPos, speed * Time.deltaTime);
        transform.position = newPos;
        
        //rotate movement direction
      //  bird.transform.rotation = Quaternion.Slerp(bird.transform.rotation, Quaternion.LookRotation(newPos), Time.deltaTime * 40f);

        Debug.Log("Chase");

        /*
        //seek code
        if (canChase == true)
        {
            bird.transform.position = worm.transform.position;
        }
        */
    }
}
