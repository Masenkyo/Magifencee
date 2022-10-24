using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public float dy;
    public float dx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((GetComponent<Tower>().Enemies.Count != 0))
        {
            dy = transform.position.y - Tower.targetenemy.transform.position.y;
            dx = transform.position.x - Tower.targetenemy.transform.position.x;
            transform.localEulerAngles = new Vector3(0, 0, Mathf.Atan2(dy, dx) * Mathf.Rad2Deg + 90);
        }
    }
}
