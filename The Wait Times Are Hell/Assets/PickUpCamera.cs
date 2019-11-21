using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCamera : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Inventory;
    public GameObject CameraObject;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit RayHit;
            Ray RayItem = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(RayItem, out RayHit)) ;
            {
                if (RayHit.transform.name == "ObjectCamera")
                {
                    Camera1.transform.position = Inventory.transform.position;
                    CameraObject.SetActive(false);
                }
            }
        }
    }
}
