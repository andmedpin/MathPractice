using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathThing : MonoBehaviour
{
    public Transform A;
    public Transform B;
    public float scalarProjection;
    
    
    //draw in the scene view
    private void OnDrawGizmos()
    {
        Vector2 a = A.position;
        Vector2 b = B.position;
        
        Gizmos.color = Color.red;
        Gizmos.DrawLine(default, a);
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(default, b);

        //Gizmos.DrawSphere(transform.position, 1);
        
        //normalizing a and drawing it
        Vector2 aNormalized = a.normalized;
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(aNormalized, 0.1f);
        
        // scalar projection
        scalarProjection =  Vector2.Dot(aNormalized, b);
    }
}
