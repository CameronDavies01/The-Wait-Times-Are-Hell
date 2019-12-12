using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDispensorEmpty : MonoBehaviour
{
    public GameObject WD1;
    public GameObject WD2;
    public GameObject WD3;
    public GameObject WD4;
    public GameObject WD5;
    public GameObject Jill;
    public GameObject GoToForJill;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit RayHit;
            Ray RayItem = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(RayItem, out RayHit));
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
                }
            }
        }
    }
}
