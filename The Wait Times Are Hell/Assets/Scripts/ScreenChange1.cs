using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenChange1 : MonoBehaviour
{
    public GameObject SpriteBook;
    public GameObject SpriteEquals;
    public GameObject SpriteBed;
    public GameObject SpriteHeart;
    public GameObject SpriteKaren;
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
                if (RayHit.transform.name == "LeftNeonArrow1")
                {
                    if (CurrentScreen == 1)
                    {
                        SpriteBook.SetActive(false);
                        SpriteEquals.SetActive(false);
                        SpriteBed.SetActive(false);
                        SpriteHeart.SetActive(true);
                        SpriteKaren.SetActive(true);
                        CurrentScreen = 2;
                    }
                    else if (CurrentScreen == 2)
                    {
                        SpriteBook.SetActive(true);
                        SpriteEquals.SetActive(true);
                        SpriteBed.SetActive(true);
                        SpriteHeart.SetActive(false);
                        SpriteKaren.SetActive(false);
                        CurrentScreen = 1;

                    }
                }
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit RayHit;
            Ray RayItem = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(RayItem, out RayHit))
            {
                if (RayHit.transform.name == "RightNeonArrow1")
                {
                    if (CurrentScreen == 1)
                    {
                        SpriteBook.SetActive(false);
                        SpriteEquals.SetActive(false);
                        SpriteBed.SetActive(false);
                        SpriteHeart.SetActive(true);
                        SpriteKaren.SetActive(true);
                        CurrentScreen = 2;
                    }
                    else if (CurrentScreen == 2)
                    {
                        SpriteBook.SetActive(true);
                        SpriteEquals.SetActive(true);
                        SpriteBed.SetActive(true);
                        SpriteHeart.SetActive(false);
                        SpriteKaren.SetActive(false);
                        CurrentScreen = 1;
                    }
                }
                }
            }
        }
    }

    
