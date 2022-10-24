using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public float damage;
    public string noDMG;
    public string critDMG;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            if (collision.name != noDMG + "(Clone)") collision.GetComponent<EnemyHP>().TakeDamage(damage);
            if (collision.name == critDMG + "(Clone)") collision.GetComponent<EnemyHP>().TakeDamage(damage);
            if (gameObject.name == "WaterDroplet(Clone)" || gameObject.name == "LightningBolt(Clone)") Destroy(gameObject);
        }

    }
}
