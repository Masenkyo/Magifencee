using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalShoot : MonoBehaviour
{
    public Tower t;
    public Transform Bullet;
    public float time;
    public float speed;
    public float firerate;
    public float pp;
    
    List<Transform> bullets = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (GetComponent<Tower>().Enemies.Count > 0 && time <= 0)
        {
            Transform bulletPrefab;
            bulletPrefab = Instantiate(Bullet, transform.position, Quaternion.identity);
            if (bulletPrefab != null) bullets.Add(bulletPrefab);
            time = firerate;
            Destroy(bulletPrefab.gameObject, pp);
        }
        foreach (Transform t in bullets)
        if(t != null)t.transform.Translate(Vector3.up * speed * Time.deltaTime, transform);
    }
}
