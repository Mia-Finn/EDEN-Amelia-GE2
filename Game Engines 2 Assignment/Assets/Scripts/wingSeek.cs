using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wingSeek : SteeringBehaviour
{
    public GameObject targetGameObject = null;
    public Vector3 target = Vector3.zero;

    public override Vector3 Calculate()
    {
        return boid.SeekForce(target);
    }

    private void Update()
    {
        if (targetGameObject != null)
        {
            target = targetGameObject.transform.position;
        }
    }
}
