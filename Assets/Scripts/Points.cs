using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{    
    public int points = 100;
    public void AddPoints(int somePoints)
    {
        points += somePoints;
        
    }
    public void RemovePoints(int somePoints)
    {
        points -= somePoints;
    }
}
