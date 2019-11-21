using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeToInventory : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Jill;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit RayHit;
            Ray RayItem = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(RayItem, out RayHit)) ;
            {
                if (RayHit.transform.name == "Cube")
                {
                    Cube.transform.position = Jill.transform.position;
                }
            }
        }
    }
}
