using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seek : SteeringBehaviour
{
    public GameObject targetGameObject = null;
    public Vector3 target = Vector3.zero;

    //State machine stuff!!!!!
    //Bools for states
    public bool canIdle, canFlee, canChase;

    //State machine
    public enum State { Idle, Flee, Chase };
    private State currentState;

    //Stuff for triggers for states
    private GameObject flower, bird, worm;
    public float speed;

    void Start()
    {
        //Set start state
        currentState = State.Idle;

        //Find objects
        flower = GameObject.FindGameObjectWithTag("Flower");
        bird = GameObject.FindGameObjectWithTag("Bird");
        worm = GameObject.FindGameObjectWithTag("Worm");
    }

    public override Vector3 Calculate()
    {
        return boid.SeekForce(target);
    }

    public void Update()
    {
        /*
        if (targetGameObject != null)
        {
            target = targetGameObject.transform.position;
        }
        */

        boolControl();

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
    }

    void wormIdle()
    {
        //worm underground
      //  worm.SetActive(false);

        Debug.Log("Idle");
    }

    void wormFlee()
    {
        Vector3 fleeTargetPos = Vector3.MoveTowards(transform.position, flower.transform.position - gameObject.transform.position, speed * Time.deltaTime);
        transform.position = fleeTargetPos;
        Debug.Log("Flee");
    }

    void wormChase()
    {

        if (targetGameObject != null)
        {
            target = targetGameObject.transform.position;
        }

        /*
        //worm above ground
        worm.SetActive(true);

        //Move towards flower
        Vector3 chaseTargetPos = Vector3.MoveTowards(transform.position, flower.transform.position, speed * Time.deltaTime);
        transform.position = chaseTargetPos;
        */

        //Eat flower
        if (Vector3.Distance(gameObject.transform.position, flower.transform.position) < 0.5f)
        {
            flower.SetActive(false);
            Debug.Log("Eat");
        }
    }
    void boolControl()
    {
        if (targetGameObject.activeInHierarchy == false)//flower.activeInHierarchy == false)
        {
            //Go idle/underground
            canIdle = true;
            canFlee = false;
            canChase = false;
        }
        else if (Vector3.Distance(gameObject.transform.position, bird.transform.position) < 1f)
        {
            //Go away from bird
            canIdle = false;
            canFlee = true;
            canChase = false;
        }
        else if (targetGameObject.activeInHierarchy == true) //flower.activeInHierarchy == true)
        {
            //Go towards flower
            canIdle = false;
            canFlee = false;
            canChase = true;
        }
    }
}
