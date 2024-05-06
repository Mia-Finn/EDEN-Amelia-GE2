using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swoop : MonoBehaviour
{
    public GameObject bird, D1, D2;

    private void Update()
    {
        if(Vector3.Distance(D1.transform.position, bird.transform.position) < 3f)
        {
            Vector3 nextPos = D2.transform.position;
            transform.position = nextPos;
            Debug.Log("Moved to 2!");
        }
        else if (Vector3.Distance(D2.transform.position, bird.transform.position) < 5f)
        {
            Vector3 nextPos = D1.transform.position;
            transform.position = nextPos;
            Debug.Log("Moved to 3!");
        }
    }
}
