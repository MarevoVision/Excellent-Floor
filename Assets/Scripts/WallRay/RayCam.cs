﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCam : MonoBehaviour {

    public PlaceOnPlane _placeOnPlane;

    public GameObject target;
    public GameObject _UIScan;
    public GameObject _Interface;
    public GameObject planeMinusDot;
    public GameObject btn_Plus;
    public GameObject btn_minus;
    public bool plusDisable;
    public bool minusTarget;
    public bool destroyPoint;
    private bool oneShow;
    public float maxDistanceRay = 10f;

    //public float findingSquareDist = 0.5f;
    // Use this for initialization
    void Start()
    {
       minusTarget = false;
        destroyPoint = false;
        oneShow = true;
        plusDisable = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 point = new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2, 0);
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(point);
           
        if (Physics.Raycast(ray, out hit, maxDistanceRay))
        {
            //Debug.DrawLine(ray.origin, hit.point);
            if (hit.transform.gameObject.layer == 11 || hit.transform.gameObject.layer == 12)
            {
                target.transform.position = new Vector3(hit.point.x, hit.point.y - 0.02f, hit.point.z);
                target.transform.rotation = hit.transform.rotation;
                target.SetActive(true);
                _UIScan.SetActive(false);
                _Interface.SetActive(true);
                if(oneShow == true)
                {
                    _placeOnPlane.first_Box_2 = true;
                    oneShow = false;
                }

            }
            if (_placeOnPlane.points.Count > 0)
            {
                if (hit.transform.gameObject.layer == 12 && hit.transform.gameObject.transform.position == _placeOnPlane.points[_placeOnPlane.points.Count - 1])
                {
                    planeMinusDot.SetActive(true);
                    btn_Plus.SetActive(false);
                    btn_minus.SetActive(true);
                    minusTarget = true;

                    if (destroyPoint == true)
                    {
                        Destroy(hit.transform.parent.gameObject);
                        _placeOnPlane.lineRenderer.positionCount -= 1;
                        _placeOnPlane.points.RemoveAt(_placeOnPlane.points.Count - 1);
                        destroyPoint = false;
                    }

                }
            }

            if (hit.transform.gameObject.layer != 12)
            {
                planeMinusDot.SetActive(false);
                if (!plusDisable)
                {
                    btn_Plus.SetActive(true);
                }
                if (plusDisable)
                {
                    btn_Plus.SetActive(false);
                }
                btn_minus.SetActive(false);
                minusTarget = false;

            }

        }

    }

    public void MinusPoint()
    {
        destroyPoint = true;
    }

}

