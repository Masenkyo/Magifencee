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
        if (Input.GetMouseButtonDown(0) && Tower != null && CanPlace() && tilemap.GetTile(tilemap.WorldToCell(mousepos)) == Gras) Tower = null;
        else if (Input.GetMouseButtonDown(0) && Tower != null && CanPlace() && tilemap.GetTile(tilemap.WorldToCell(mousepos)) == Grass) Tower = null;
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Destroy(Tower);
        }
    }
    public void NormalTowerCannon()
    {
        if (Tower != null)
        {
            Destroy(Tower);
            Tower = Instantiate(NormalTower, mousepos, transform.rotation);
        }
        if (Tower == null)
            Tower = Instantiate(NormalTower, mousepos, transform.rotation);
    }
    public void LightningTowerTesla()
    {
        if (Tower != null)
        {
            Destroy(Tower);
            Tower = Instantiate(LightningTower, mousepos, transform.rotation);
        }
        if (Tower == null)
            Tower = Instantiate(LightningTower, mousepos, transform.rotation);
    }
    public void WaterTowerTesla()
    {
        if (Tower != null)
        {
            Destroy(Tower);
            Tower = Instantiate(WaterTower, mousepos, transform.rotation);
        }
        if (Tower == null)
            Tower = Instantiate(WaterTower, mousepos, transform.rotation);
    }
    public void FireTowerTesla()
    {
        if (Tower != null)
        {
            Destroy(Tower);
            Tower = Instantiate(FireTower, mousepos, transform.rotation);
        }
        if (Tower == null)
            Tower = Instantiate(FireTower, mousepos, transform.rotation);
    }
}