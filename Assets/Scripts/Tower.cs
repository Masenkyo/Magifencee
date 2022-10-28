using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Tower : MonoBehaviour
{
    public float Lifetime;
    public EnemyMove target;
    public static GameObject targetenemy;
    public List<GameObject> Enemies = new List<GameObject>();
    public float Range;
    private AudioSource audio;
    private void Start(){
        audio = GetComponent<AudioSource>();}
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
        if (GetComponent<NormalShoot>().time == GetComponent<NormalShoot>().firerate) audio.PlayOneShot(audio.clip);
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
