using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.Linq;
using System.Globalization;
using Mono.Cecil.Cil;

public class TowerPlace : MonoBehaviour
{
    public GameObject SpawnRange;
    public GameObject Range;
    public GameObject RangeFire;
    public GameObject RangeLightning;
    public GameObject RangeWater;
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
            SpawnRange.transform.position = mousepos;
            if (Input.GetKeyDown(KeyCode.E))
            {
                Tower.transform.Rotate(0, 0, -90);
                SpawnRange.transform.Rotate(0, 0, -90);
            }         
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Tower.transform.Rotate(0, 0, 90);
                SpawnRange.transform.Rotate(0, 0, 90);
            }
        }        
        Towers = GameObject.FindObjectsOfType<GameObject>();
        if (Input.GetMouseButtonDown(0) && Tower != null && CanPlace() && tilemap.GetTile(tilemap.WorldToCell(mousepos)) == Gras)
        {
            Tower.GetComponent<NormalShoot>().enabled = true;
            Tower = null;
            Destroy(SpawnRange);
            
        }
        else if (Input.GetMouseButtonDown(0) && Tower != null && CanPlace() && tilemap.GetTile(tilemap.WorldToCell(mousepos)) == Grass)
        {
            Tower.GetComponent<NormalShoot>().enabled = true;
            Tower = null;
            Destroy(SpawnRange);
            
        }
        if (Input.GetKeyDown(KeyCode.Backspace) && Tower != null)
        {
            Destroy(Tower);
            Destroy(SpawnRange);
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
            Destroy(SpawnRange);
            Tower = Instantiate(NormalTower, mousepos, transform.rotation);
            SpawnRange = Instantiate(Range, mousepos, transform.rotation);
            GameObject.Find("Canvas").GetComponent<Points>().RemovePoints(Cost);
        }
        if (Tower == null && GameObject.Find("Canvas").GetComponent<Points>().points >= 50)
        {
            Cost = 50;
            Tower = Instantiate(NormalTower, mousepos, transform.rotation);
            SpawnRange = Instantiate(Range, mousepos, transform.rotation);
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
            Destroy(SpawnRange);
            Tower = Instantiate(LightningTower, mousepos, transform.rotation);
            SpawnRange = Instantiate(RangeLightning, mousepos, transform.rotation);
            GameObject.Find("Canvas").GetComponent<Points>().RemovePoints(Cost);
        }

        if (Tower == null && GameObject.Find("Canvas").GetComponent<Points>().points >= 150)
        {
            Cost = 150;
            Tower = Instantiate(LightningTower, mousepos, transform.rotation);
            SpawnRange = Instantiate(RangeLightning, mousepos, transform.rotation);
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
            Destroy(SpawnRange);
            Tower = Instantiate(WaterTower, mousepos, transform.rotation);
            SpawnRange = Instantiate(RangeWater, mousepos, transform.rotation);
            GameObject.Find("Canvas").GetComponent<Points>().RemovePoints(Cost);
        }

        if (Tower == null && GameObject.Find("Canvas").GetComponent<Points>().points >= 300)
        {
            Cost = 300;
            Tower = Instantiate(WaterTower, mousepos, transform.rotation);
            SpawnRange = Instantiate(RangeWater, mousepos, transform.rotation);
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
            Destroy(SpawnRange);
            Tower = Instantiate(FireTower, mousepos, transform.rotation);
            SpawnRange = Instantiate(RangeFire, mousepos, transform.rotation);
            GameObject.Find("Canvas").GetComponent<Points>().RemovePoints(Cost);
        }

        if (Tower == null && GameObject.Find("Canvas").GetComponent<Points>().points >= 250)
        {
            Cost = 250;
            Tower = Instantiate(FireTower, mousepos, transform.rotation);
            SpawnRange = Instantiate(RangeFire, mousepos, transform.rotation);
            GameObject.Find("Canvas").GetComponent<Points>().RemovePoints(Cost);
        }
    }
}