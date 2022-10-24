using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public float hp = 10;
    public int points;
    public void TakeDamage(float amountOfDamage)
    {
        hp -= amountOfDamage;
        if (hp <= 0)
        {
            GameObject.Find("Canvas").GetComponent<Points>().AddPoints(points);
            transform.position = new Vector2(50, 0);
            Destroy(gameObject, 0.5f);
        }
    }
}
