using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPUI : MonoBehaviour
{
    public HPGate hp;
    public Points Point;
    public Text HPText;
    public Text Points;
    
    void Start()
    {
        
    }
    void Update()
    {
        HPText.text = hp.hp.ToString();
        Points.text = Point.points.ToString();
    }
}
