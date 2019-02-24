using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMaterial : MonoBehaviour {

    public Material mat1, mat2, mat3, mat4, mat5, mat6, mat7, mat8, mat9, mat10;
    public Material UseNow;
    public int usenowNumber;
    public PlaceOnPlane _PlaceOnPlane;
    public bool work;
    public CartManager _CartManager;
    public GameManager _GameManager;
    // Use this for initialization
    void Start()
    {
        //Material1();
    }

    public void GoAR()
    {
        if (_PlaceOnPlane.NumberItemMenu == 0)
        {
            Material1();
        }
        if (_PlaceOnPlane.NumberItemMenu == 1)
        {
            Material1();
        }
        if (_PlaceOnPlane.NumberItemMenu == 2)
        {
            Material2();
        }
        if (_PlaceOnPlane.NumberItemMenu == 3)
        {
            Material3();
        }
        if (_PlaceOnPlane.NumberItemMenu == 4)
        {
            Material4();
        }
        if (_PlaceOnPlane.NumberItemMenu == 5)
        {
            Material5();
        }
        if (_PlaceOnPlane.NumberItemMenu == 6)
        {
            Material6();
        }
        if (_PlaceOnPlane.NumberItemMenu == 7)
        {
            Material7();
        }
        if (_PlaceOnPlane.NumberItemMenu == 8)
        {
            Material8();
        }
        if (_PlaceOnPlane.NumberItemMenu == 9)
        {
            Material9();
        }
        if (_PlaceOnPlane.NumberItemMenu == 10)
        {
            Material10();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Material1()
    {
        work = true;
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Polygon");
        foreach (GameObject go in gos)
        {
            go.GetComponent<MeshRenderer>().material = mat1;
        }
        UseNow = mat1;
        usenowNumber = 1;
        _GameManager.TitleItem.text = _CartManager.CartListItem.List[0].NameItem;
        _PlaceOnPlane.priceRoll = _CartManager.CartListItem.List[0].Price;
        //if (_PlaceOnPlane.changePlaneMode == false)
        //{
        //    spawnPolygonQuadWallpaper.transform.GetChild(0).GetComponent<VoxelMap>().fillTypeIndex = usenowNumber;
        //}
    }

    public void Material2()
    {
        work = true;
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Polygon");
        foreach (GameObject go in gos)
        {
            go.GetComponent<MeshRenderer>().material = mat2;
        }
        UseNow = mat2;
        usenowNumber = 2;
        _GameManager.TitleItem.text = _CartManager.CartListItem.List[1].NameItem;
        _PlaceOnPlane.priceRoll = _CartManager.CartListItem.List[1].Price; ;
        //if (_PlaceOnPlane.changePlaneMode == false)
        //{
        //    spawnPolygonQuadWallpaper.transform.GetChild(0).GetComponent<VoxelMap>().fillTypeIndex = usenowNumber;
        //}
    }

    public void Material3()
    {
        work = true;
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Polygon");
        foreach (GameObject go in gos)
        {
            go.GetComponent<MeshRenderer>().material = mat3;
        }
        UseNow = mat3;
        usenowNumber = 3;
        _GameManager.TitleItem.text = _CartManager.CartListItem.List[2].NameItem;
        _PlaceOnPlane.priceRoll = _CartManager.CartListItem.List[2].Price;
        //if (_PlaceOnPlane.changePlaneMode == false)
        //{
        //    spawnPolygonQuadWallpaper.transform.GetChild(0).GetComponent<VoxelMap>().fillTypeIndex = usenowNumber;
        //}
    }

    public void Material4()
    {
        work = true;
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Polygon");
        foreach (GameObject go in gos)
        {
            go.GetComponent<MeshRenderer>().material = mat4;
        }
        UseNow = mat4;
        usenowNumber = 4;
        _GameManager.TitleItem.text = _CartManager.CartListItem.List[3].NameItem;
        _PlaceOnPlane.priceRoll = _CartManager.CartListItem.List[3].Price;
        //if (_PlaceOnPlane.changePlaneMode == false)
        //{
        //    spawnPolygonQuadWallpaper.transform.GetChild(0).GetComponent<VoxelMap>().fillTypeIndex = usenowNumber;
        //}
    }

    public void Material5()
    {
        work = true;
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Polygon");
        foreach (GameObject go in gos)
        {
            go.GetComponent<MeshRenderer>().material = mat5;
        }
        UseNow = mat5;
        usenowNumber = 5;
        _GameManager.TitleItem.text = _CartManager.CartListItem.List[4].NameItem;
        _PlaceOnPlane.priceRoll = _CartManager.CartListItem.List[4].Price;
        //if (_PlaceOnPlane.changePlaneMode == false)
        //{
        //    spawnPolygonQuadWallpaper.transform.GetChild(0).GetComponent<VoxelMap>().fillTypeIndex = usenowNumber;
        //}
    }

    public void Material6()
    {
        work = true;
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Polygon");
        foreach (GameObject go in gos)
        {
            go.GetComponent<MeshRenderer>().material = mat6;
        }
        UseNow = mat6;
        usenowNumber = 6;
        _GameManager.TitleItem.text = _CartManager.CartListItem.List[5].NameItem;
        _PlaceOnPlane.priceRoll = _CartManager.CartListItem.List[5].Price;
        //if (_PlaceOnPlane.changePlaneMode == false)
        //{
        //    spawnPolygonQuadWallpaper.transform.GetChild(0).GetComponent<VoxelMap>().fillTypeIndex = usenowNumber;
        //}
    }

    public void Material7()
    {
        work = true;
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Polygon");
        foreach (GameObject go in gos)
        {
            go.GetComponent<MeshRenderer>().material = mat7;
        }
        UseNow = mat7;
        usenowNumber = 7;
        _GameManager.TitleItem.text = _CartManager.CartListItem.List[6].NameItem;
        _PlaceOnPlane.priceRoll = _CartManager.CartListItem.List[6].Price;
        //if (_PlaceOnPlane.changePlaneMode == false)
        //{
        //    spawnPolygonQuadWallpaper.transform.GetChild(0).GetComponent<VoxelMap>().fillTypeIndex = usenowNumber;
        //}
    }

    public void Material8()
    {
        work = true;
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Polygon");
        foreach (GameObject go in gos)
        {
            go.GetComponent<MeshRenderer>().material = mat8;
        }
        UseNow = mat8;
        usenowNumber = 8;
        _GameManager.TitleItem.text = _CartManager.CartListItem.List[7].NameItem;
        _PlaceOnPlane.priceRoll = _CartManager.CartListItem.List[7].Price;
        //if (_PlaceOnPlane.changePlaneMode == false)
        //{
        //    spawnPolygonQuadWallpaper.transform.GetChild(0).GetComponent<VoxelMap>().fillTypeIndex = usenowNumber;
        //}
    }

    public void Material9()
    {
        work = true;
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Polygon");
        foreach (GameObject go in gos)
        {
            go.GetComponent<MeshRenderer>().material = mat9;
        }
        UseNow = mat9;
        usenowNumber = 9;
        _GameManager.TitleItem.text = _CartManager.CartListItem.List[8].NameItem;
        _PlaceOnPlane.priceRoll = _CartManager.CartListItem.List[8].Price;
        //if (_PlaceOnPlane.changePlaneMode == false)
        //{
        //    spawnPolygonQuadWallpaper.transform.GetChild(0).GetComponent<VoxelMap>().fillTypeIndex = usenowNumber;
        //}
    }

    public void Material10()
    {
        work = true;
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Polygon");
        foreach (GameObject go in gos)
        {
            go.GetComponent<MeshRenderer>().material = mat10;
        }
        UseNow = mat10;
        usenowNumber = 10;
        _GameManager.TitleItem.text = _CartManager.CartListItem.List[9].NameItem;
        _PlaceOnPlane.priceRoll = _CartManager.CartListItem.List[9].Price;
        //if (_PlaceOnPlane.changePlaneMode == false)
        //{
        //    spawnPolygonQuadWallpaper.transform.GetChild(0).GetComponent<VoxelMap>().fillTypeIndex = usenowNumber;
        //}
    }
}
