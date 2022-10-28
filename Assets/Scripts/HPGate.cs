using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HPGate : MonoBehaviour
{
    [SerializeField]public int hp = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (hp < 1)
        {
            GoToDead();
        }
    }
    void GoToDead()
    {
        SceneManager.LoadScene("Dead");
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == ("Enemy(Clone)"))
        {
            hp-=3;
        }
        if (other.name == ("FireEnemy(Clone)"))
        {
            hp -= 12;
        }
        if (other.name == ("WaterEnemy(Clone)"))
        {
            hp -= 5;
        }
        if (other.name == ("LightningEnemy(Clone)"))
        {
            hp -= 10;
        }
    }
}
