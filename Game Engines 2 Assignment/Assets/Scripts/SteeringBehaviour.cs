using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(boid))]

public abstract class SteeringBehaviour : MonoBehaviour
{
    public float weight = 1.0f;
    public Vector3 force;

    [HideInInspector]
    public boid boid;

    public void Awake()
    {
        boid = GetComponent<boid>();
    }

    public abstract Vector3 Calculate();
}
