using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.Linq;
using System.Globalization;
using Mono.Cecil.Cil;

public class TowerPlace : MonoBehaviour
{
    public GameObject NormalTower;
    public GameObject LightningTower;
    public GameObject WaterTower;
    public GameObject FireTower;
    public GameObject Tower;
    public Tilemap tilemap;
    public TileBase Gras;
    public TileBase Grass;
    public int Cost;
    private Camera cam => Camera.main.GetComponent<Camera>();
    Vector3 mousepos => new Vector3((Mathf.Floor(cam.ScreenToWorldPoint(Input.mousePosition).x)) + 0.5f, (Mathf.Floor(cam.ScreenToWorldPoint(Input.mousePosition).y)) + 0.5f, 0);
    GameObject[] Towers;
    [SerializeField]
    bool CanPlace()
    {
        foreach (GameObject T in Towers)
        {
            if (T.CompareTag("Tower") && T != Tower && T.transform.position == Tower.transform.position)
                return false;

        }
        return true;
    }
    private void Start()
    {
        
    }
    void Update()
    {
        if (Tower != null)
        {
            Tower.transform.position = mousepos;
            if (Input.GetKeyDown(KeyCode.E)) Tower.transform.Rotate(0, 0, -90);          
            if (Input.GetKeyDown(KeyCode.Q)) Tower.transform.Rotate(0, 0, 90);           
        }        
        Towers = GameObject.FindObjectsOfType<GameObject>();
        if (Input.GetMouseButtonDown(0) && Tower != null && CanPlace() && tilemap.GetTile(tilemap.WorldToCell(mousepos)) == Gras)
        {
            Tower.GetComponent<NormalShoot>().enabled = true;
            Tower = null;
        }
        else if (Input.GetMouseButtonDown(0) && Tower != null && CanPlace() && tilemap.GetTile(tilemap.WorldToCell(mousepos)) == Grass)
        {
            Tower.GetComponent<NormalShoot>().enabled = true;
            Tower = null;
        }
        if (Input.GetKeyDown(KeyCode.Backspace) && Tower != null)
        {
            Destroy(Tower);
            GameObject.Find("Canvas").GetComponent<Points>().points += Cost;
        }
    }
    public void NormalTowerCannon()
    {
        
        if (Tower != null && GameObject.Find("Canvas").GetComponent<Points>().points >= 50)
        {
            GameObject.Find("Canvas").GetComponent<Points>().AddPoints(Cost);
            Cost = 50;
            Destroy(Tower);
            Tower = Instantiate(NormalTower, mousepos, transform.rotation);
            GameObject.Find("Canvas").GetComponent<Points>().RemovePoints(Cost);
        }
        Cost = 50;
        if (Tower == null && GameObject.Find("Canvas").GetComponent<Points>().points >= Cost)
        {
            Tower = Instantiate(NormalTower, mousepos, transform.rotation);
            GameObject.Find("Canvas").GetComponent<Points>().RemovePoints(Cost);
        }            
    }
    public void LightningTowerTesla()
    {

        if (Tower != null && GameObject.Find("Canvas").GetComponent<Points>().points >= 150)
        {
            GameObject.Find("Canvas").GetComponent<Points>().AddPoints(Cost);
            Cost = 150;
            Destroy(Tower);
            Tower = Instantiate(LightningTower, mousepos, transform.rotation);
            GameObject.Find("Canvas").GetComponent<Points>().RemovePoints(Cost);
        }
        Cost = 150;
        if (Tower == null && GameObject.Find("Canvas").GetComponent<Points>().points >= Cost)
        {
            Tower = Instantiate(LightningTower, mousepos, transform.rotation);
            GameObject.Find("Canvas").GetComponent<Points>().RemovePoints(Cost);
        }
    }
    public void WaterTowerTesla()
    {

        if (Tower != null && GameObject.Find("Canvas").GetComponent<Points>().points >= 300)
        {
            GameObject.Find("Canvas").GetComponent<Points>().AddPoints(Cost);
            Cost = 300;
            Destroy(Tower);
            Tower = Instantiate(NormalTower, mousepos, transform.rotation);
            GameObject.Find("Canvas").GetComponent<Points>().RemovePoints(Cost);
        }
        Cost = 300;
        if (Tower == null && GameObject.Find("Canvas").GetComponent<Points>().points >= Cost)
        {
            Tower = Instantiate(WaterTower, mousepos, transform.rotation);
            GameObject.Find("Canvas").GetComponent<Points>().RemovePoints(Cost);
        }
    }
    public void FireTowerTesla()
    {

        if (Tower != null && GameObject.Find("Canvas").GetComponent<Points>().points >= 250)
        {
            GameObject.Find("Canvas").GetComponent<Points>().AddPoints(Cost);
            Cost = 250;
            Destroy(Tower);
            Tower = Instantiate(NormalTower, mousepos, transform.rotation);
            GameObject.Find("Canvas").GetComponent<Points>().RemovePoints(Cost);
        }
        Cost = 250;
        if (Tower == null && GameObject.Find("Canvas").GetComponent<Points>().points >= Cost)
        {
            Tower = Instantiate(FireTower, mousepos, transform.rotation);
            GameObject.Find("Canvas").GetComponent<Points>().RemovePoints(Cost);
        }
    }
}