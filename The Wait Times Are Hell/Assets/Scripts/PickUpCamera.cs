﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpCamera : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject CameraObject;
    public int CameraPosition;
    public bool CameraButtonOn;

    public GameObject DummyCamera;

    public GameObject Book1;
    public GameObject BookObject;
    public int BookPosition;
    public bool BookButtonOn;

    public GameObject Karen1;
    public int KarenPosition;
    public bool KarenButtonOn;

    public GameObject KarenBook1;
    public int KarenBookPosition;
    public bool KarenBookButtonOn;

    GameObject InventoryPosition;
    int WhereTo;
    public GameObject WD1;
    public GameObject WD2;
    public GameObject WD3;
    public GameObject WD4;
    public GameObject WD5;
    public GameObject Jill;
    public GameObject GoToForJill;
    public GameObject Emily;
    public GameObject GoToForEmily;
    public GameObject Menu;
    private void Start()
    {
        CameraButtonOn = false;
        InventoryPosition = GameObject.Find("1");
        WhereTo = 1;


    }
    void Update()
    {
        if (Input.GetKeyDown(CameraPosition.ToString()))
        {
            CameraButtonOn = true;
        }
        if (Input.GetKeyDown(BookPosition.ToString()))
        {
            BookButtonOn = true;
        }
        if (Input.GetKeyDown(KarenPosition.ToString()))
        {
            KarenButtonOn = true;
        }
        if (Input.GetKeyDown(KarenBookPosition.ToString()))
        {
            KarenBookButtonOn = true;
        }

        if ((KarenButtonOn == true) & (BookButtonOn == true))
        {
            Book1.SetActive(false);
            Karen1.SetActive(false);
            KarenBook1.transform.position = InventoryPosition.transform.position;

        }


        if ((Input.GetKeyDown("i")) & (Menu.activeInHierarchy == false))
        {
            Menu.SetActive(true);
        }
        else if ((Input.GetKeyDown("i")) & (Menu.activeInHierarchy == true))
        {
            Menu.SetActive(false);
        }
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit RayHit;
            Ray RayItem = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(RayItem, out RayHit)) ;
            {
                if (RayHit.transform.name == "ObjectWaterDispensor1")
                {
                    WD2.transform.position = WD1.transform.position;
                    WD1.SetActive(false);
                }

                if (RayHit.transform.name == "ObjectWaterDispensor2")
                {
                    WD3.transform.position = WD2.transform.position;
                    WD2.SetActive(false);
                }
                if (RayHit.transform.name == "ObjectWaterDispensor3")
                {
                    WD4.transform.position = WD3.transform.position;
                    WD3.SetActive(false);
                }
                if (RayHit.transform.name == "ObjectWaterDispensor4")
                {
                    WD5.transform.position = WD4.transform.position;
                    WD4.SetActive(false);
                    Jill.transform.position = GoToForJill.transform.position;
                    CameraObject.transform.position = DummyCamera.transform.position;
                    DummyCamera.SetActive(false);
                }
            }
            if (WhereTo == 1)
            {
                InventoryPosition = GameObject.Find("1");
            }
            if (WhereTo == 2)
            {
                InventoryPosition = GameObject.Find("2");
            }
            if (WhereTo == 3)
            {
                InventoryPosition = GameObject.Find("3");
            }
            if (WhereTo == 4)
            {
                InventoryPosition = GameObject.Find("4");
            }
            if (WhereTo == 5)
            {
                InventoryPosition = GameObject.Find("5");
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit RayHit;
            Ray RayItem = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(RayItem, out RayHit));
            {
                if (RayHit.transform.name == "ObjectCamera")
                {
                    Camera1.transform.position = InventoryPosition.transform.position;
                    CameraObject.SetActive(false);
                    CameraPosition = WhereTo;
                    WhereTo = WhereTo + 1;
                    

                }
                if (RayHit.transform.name == "ObjectBook")
                {
                    Book1.transform.position = InventoryPosition.transform.position;
                    BookObject.SetActive(false);
                    BookPosition = WhereTo;
                    WhereTo = WhereTo + 1;
                }
                if ((RayHit.transform.name == "KarenEverTorture") && (CameraButtonOn == true))
                {
                        Karen1.transform.position = InventoryPosition.transform.position;
                    KarenPosition = WhereTo;
                    WhereTo = WhereTo + 1;
                   
                }
                if (RayHit.transform.name == "DummyObjectCamera")
                {
                    Emily.SetActive(false);
                    Emily.transform.position = GoToForEmily.transform.position;
                    Emily.SetActive(true);
                }

            }     
        }
    }
}
