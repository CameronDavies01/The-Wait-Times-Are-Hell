using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightArrowClicked1 : MonoBehaviour
{
    public GameObject SpriteBook;
    public GameObject SpriteEquals;
    public GameObject SpriteBed;
    public GameObject SpriteHeart;
    public GameObject SpriteKaren;
    int WhatToSwitchTo;
    private void Update()
    {

    }
    void OnMouseDown()
        {
        SpriteBook.SetActive(false);
        SpriteEquals.SetActive(false);
        SpriteBed.SetActive(false);
        SpriteHeart.SetActive(true);
        SpriteKaren.SetActive(true);

    }
    }
