using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerGrow : MonoBehaviour
{

    public GameObject worm, flower;

    public float speed;

    private Vector3 newPos;

    // Update is called once per frame
    void Update()
    {
        /*
        if(Vector3.Distance(worm.transform.position, flower.transform.position) < 1f)
        {
            flower.transform.position = new Vector3(Random.value, Random.value, Random.value);
            //Debug.Log("Moved!");
        }    
        */

        //move to new random position
        if (Vector3.Distance(worm.transform.position, flower.transform.position) < 1f)
        {
            goNewPos();
            transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * speed);
        }
    }

    void goNewPos()
    {
        newPos = new Vector3(Random.Range(-200.0f, 200.0f), transform.position.y ,Random.Range(-200.0f, 200.0f));
    }
}
