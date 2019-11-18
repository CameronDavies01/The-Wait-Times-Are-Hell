using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenChange2 : MonoBehaviour
{
    public GameObject SpriteJob1;
    public GameObject SpriteEquals;
    public GameObject SpriteShield;
    public GameObject SpriteCamera;
    public GameObject SpriteJob2;
    public GameObject SpriteEmptyWD;
    public GameObject SpriteRightArrow;
    public GameObject SpriteFullWD;
    int CurrentScreen;

    private void Start()
    {
        CurrentScreen = 1;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit RayHit;
            Ray RayItem = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(RayItem, out RayHit));
            {
                if (RayHit.transform.name == "LeftNeonArrow3")
                {
                    if (CurrentScreen == 1)
                    {
                        SpriteJob1.SetActive(false);
                        SpriteEquals.SetActive(false);
                        SpriteShield.SetActive(false);
                        SpriteCamera.SetActive(false);
                        SpriteJob2.SetActive(true);
                        SpriteEmptyWD.SetActive(true);
                        SpriteRightArrow.SetActive(true);
                        SpriteFullWD.SetActive(true);
                        CurrentScreen = 2;
                    }
                    else if (CurrentScreen == 2)
                    {
                        SpriteJob1.SetActive(true);
                        SpriteEquals.SetActive(true);
                        SpriteShield.SetActive(true);
                        SpriteCamera.SetActive(true);
                        SpriteJob2.SetActive(false);
                        SpriteEmptyWD.SetActive(false);
                        SpriteRightArrow.SetActive(false);
                        SpriteFullWD.SetActive(false);
                        CurrentScreen = 1;
                    }
                }
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit RayHit;
            Ray RayItem = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(RayItem, out RayHit));
            {
                if (RayHit.transform.name == "RightNeonArrow3")
                {
                    if (CurrentScreen == 1)
                    {
                        SpriteJob1.SetActive(false);
                        SpriteEquals.SetActive(false);
                        SpriteShield.SetActive(false);
                        SpriteCamera.SetActive(false);
                        SpriteJob2.SetActive(true);
                        SpriteEmptyWD.SetActive(true);
                        SpriteRightArrow.SetActive(true);
                        SpriteFullWD.SetActive(true);
                        CurrentScreen = 2;
                    }
                    else if (CurrentScreen == 2)
                    {
                        SpriteJob1.SetActive(true);
                        SpriteEquals.SetActive(true);
                        SpriteShield.SetActive(true);
                        SpriteCamera.SetActive(true);
                        SpriteJob2.SetActive(false);
                        SpriteEmptyWD.SetActive(false);
                        SpriteRightArrow.SetActive(false);
                        SpriteFullWD.SetActive(false);
                        CurrentScreen = 1;
                    }
                }
            }
        }
    }
}
