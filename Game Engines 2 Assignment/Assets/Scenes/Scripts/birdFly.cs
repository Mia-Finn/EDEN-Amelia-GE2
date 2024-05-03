using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdFly : MonoBehaviour
{
    public float speed;
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        //fly towards a target
        Vector3 targetPos = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        transform.position = targetPos;
      //  Debug.Log("Moving!");
    }
}
