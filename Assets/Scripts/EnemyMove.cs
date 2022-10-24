using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMove : MonoBehaviour
{
    float pime = 0.05f;
    float speed = 1;
    public float Lifetime;
    float Starttime;
    int i = 0;
    Vector3[] array = new Vector3[] { (new Vector3(-0.5f, 1.5f)), (new Vector3(-6.5f, 1.5f)), (new Vector3(-6.5f, -2.5f)), (new Vector3(1.5f, -2.5f)), (new Vector3(1.5f, -0.5f)), (new Vector3(3.5f, -0.5f)), (new Vector3(3.5f, 3.5f)), (new Vector3(7.5f, 3.5f)), (new Vector3(7.5f, -2.5f)), (new Vector3(5.5f, -2.5f)), (new Vector3(5.5f, -5f)) };
    private void Start()
    {
        Starttime = Time.time;
    }
    void Update()
    {
        Vector3 Direction = array[i] - transform.position;
        Direction /= Direction.magnitude;
        transform.position += Time.deltaTime * Direction * speed;
        if ((array[i] - transform.position).magnitude < 0.01f)
        {
            i++;
        }
        Lifetime += (Time.time - Starttime) *speed;
        pime -= Time.deltaTime;
        if (pime <= 0) speed = 1;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (CompareTag("LightningBolt") || collision.tag == "LightningBolt")
        {
            speed = 0;
            pime = 0.05f;
        }
        
    }
}
