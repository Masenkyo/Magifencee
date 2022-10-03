using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    private float dy;
    private float dx;
    public List<GameObject> Enemies = new List<GameObject>();
    public List<Transform> Enemies2 = new List<Transform>();
    public float Range;
    void Start()
    {
        
    }


    void Update()
    {
        //function();
        foreach (GameObject t in Enemies)
        {
            dy = transform.position.y - t.transform.position.y;
            dx = transform.position.x - t.transform.position.x;
            transform.localEulerAngles = new Vector3(0, 0, Mathf.Atan2(dy, dx) * Mathf.Rad2Deg + 90);
            
        }
        
    }
    /*private void function()
    {
        GameObject[] Aim = GameObject.FindObjectsOfType<GameObject>();
        foreach (GameObject Enemy in Aim)
        {
            if (Enemy.CompareTag("Enemy") && (transform.position - Enemy.transform.position).magnitude <= Range && !Enemies2.Contains(Enemy.transform))
            {
                Enemies2.Add(Enemy.transform);
            }
            
        }
    }*/
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
