using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayRayCast : MonoBehaviour
{


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray straight down.
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up * 10);
            Debug.DrawRay(transform.position, Vector2.up * 10, Color.yellow);
            // If it hits something...
            if (hit.collider.gameObject.CompareTag("Laaayer")) Debug.Log("Hit");
            else if (hit.collider.gameObject.CompareTag("Respawn")) Debug.Log("No Hit");
        }        
    }
}
