using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public float Lifetime;
    public EnemyMove target;
    public static GameObject targetenemy;
    public List<GameObject> Enemies = new List<GameObject>();
    public float Range;
    void Update()
    {
        Lifetime = 0;
        for (int i = 0; i < Enemies.Count; i++)
        {
            if (Enemies[i].GetComponent<EnemyMove>().Lifetime > Lifetime)
            {
                Lifetime = Enemies[i].GetComponent<EnemyMove>().Lifetime;
                targetenemy = Enemies[i];
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.CompareTag("Enemy"))
        {
            Enemies.Add(collision.gameObject);

        }       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Enemies.Remove(collision.gameObject);

        }       
    }
}
