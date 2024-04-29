using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(myBoid))]

public abstract class SteeringBehaviour : MonoBehaviour
{
    public float weight = 1.0f;
    public Vector3 force;

    [HideInInspector]
    public myBoid boid;

    public void Awake()
    {
        boid = GetComponent<myBoid>();
    }

    public abstract Vector3 Calculate();
}
