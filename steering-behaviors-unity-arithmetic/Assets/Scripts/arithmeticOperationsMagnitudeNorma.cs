using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arithmeticOperationsMagnitudeNorma: MonoBehaviour
{
    public Vector2 v3 = new Vector2(0, 0);

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.LogFormat("The Longitude is {0} é {1}", v3, Magnitude(v3));
            Debug.LogFormat("The vector {0} normalize is {1}", v3, Normalize(v3));
            Debug.LogFormat("he vector {0} normalize with the method 'normalized' is {1}", v3, v3.normalized);
        }
   
    }

    float Magnitude(Vector2 v)
    {
        return Mathf.Sqrt(v.x * v.x + v.y * v.y);
    }

    Vector2 Normalize(Vector2 v)
    {
        return v / Magnitude(v);
    }

}
