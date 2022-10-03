using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayRayCast : MonoBehaviour
{
    
    void FixedUpdate()
    {
        
        int layerMask = 0;


        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }
}
