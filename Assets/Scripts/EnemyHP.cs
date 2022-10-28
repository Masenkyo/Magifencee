using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public float hp;
    public float maxhp;
    public int points;
    public GameObject healthBarUI;
    public Slider slider;

    private void Start(){
        maxhp = hp;}
    private void Update(){
        if (hp > 0) slider.value = CalculateHealth();}
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
    float CalculateHealth(){
        return hp / maxhp;}
}
