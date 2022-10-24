using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Gate"))
        {
            transform.position = new Vector2(50, 0);
            Destroy(gameObject, 0.5f);    
        }
    }
}
