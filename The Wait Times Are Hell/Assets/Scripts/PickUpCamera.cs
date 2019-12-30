using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpCamera : MonoBehaviour
{
    public Sprite IS1DA;
    public Sprite IS2DA;
    public Sprite IS3DA;
    public Sprite IS4DA;
    public Sprite IS5DA;
    public Sprite IS1A;
    public Sprite IS2A;
    public Sprite IS3A;
    public Sprite IS4A;
    public Sprite IS5A;

    public GameObject LustLock;
    public GameObject GluttonyLock;
    public GameObject GreedLock;
    public GameObject WrathLock;
    public GameObject SlothLock;
    public GameObject PrideLock;
    public GameObject EnvyLock;

    public GameObject Camera1;
    public GameObject CameraObject;
    public int CameraPosition;
    public bool CameraButtonOn;

    public AudioSource Good;
    public AudioSource Bad;
    public AudioSource Unlock;

    public GameObject Eye1;
    public GameObject EyeObject;
    public int EyePosition;
    public bool EyeButtonOn;

    public GameObject Globe1;
    public GameObject GlobeObject;
    public int GlobePosition;
    public bool GlobeButtonOn;

    public GameObject DummyCamera;
    public GameObject DummyKaren;

    public GameObject Book1;
    public GameObject BookObject;
    public int BookPosition;
    public bool BookButtonOn;

    public GameObject Cup1;
    public GameObject Cup2;
    public GameObject Cup3;
    public GameObject Cup4;
    public int CupPosition;
    public int FourCupPosition;
    public bool CupButtonOn;

    public GameObject Karen1;
    public GameObject KarenObject;
    public int KarenPosition;
    public bool KarenButtonOn;

    public GameObject Pizza1;
    public GameObject PizzaObject;
    public int PizzaPosition;
    public bool PizzaButtonOn;

    public GameObject Bob1;
    public GameObject BobObject;
    public int BobPosition;
    public bool BobButtonOn;

    public GameObject Jill1;
    public GameObject JillObject;
    public int JillPosition;
    public bool JillButtonOn;

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
        if (Input.GetKeyDown(PizzaPosition.ToString()))
        {
            PizzaButtonOn = true;
        }
        if (Input.GetKeyDown(FourCupPosition.ToString()))
        {
            CupButtonOn = true;
        }
        if (Input.GetKeyDown(EyePosition.ToString()))
        {
            EyeButtonOn = true;
        }
        if (Input.GetKeyDown(BobPosition.ToString()))
        {
            BobButtonOn = true;
        }
        if (Input.GetKeyDown(JillPosition.ToString()))
        {
            JillButtonOn = true;
        }
        if (Input.GetKeyDown(GlobePosition.ToString()))
        {
            GlobeButtonOn = true;
        }
        if ((KarenButtonOn == true) && (BookButtonOn == true))
        {
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
            if (WhereTo == 6)
            {
                InventoryPosition = GameObject.Find("6");
            }
            if (WhereTo == 7)
            {
                InventoryPosition = GameObject.Find("7");
            }
            if (WhereTo == 8)
            {
                InventoryPosition = GameObject.Find("8");
            }
            if (WhereTo == 9)
            {
                InventoryPosition = GameObject.Find("9");
            }
            if (WhereTo == 10)
            {
                InventoryPosition = GameObject.Find("0");
            }
            KarenBook1.transform.position = GameObject.Find("1").transform.position;
            KarenBookPosition = 1;
            Karen1.SetActive(false);
            Book1.SetActive(false);
            Good.Play();
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
            if (Physics.Raycast(RayItem, out RayHit));
            {
                if (RayHit.transform.name == "ObjectWaterDispensor1")
                {
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
                    if (WhereTo == 6)
                    {
                        InventoryPosition = GameObject.Find("6");
                    }
                    if (WhereTo == 7)
                    {
                        InventoryPosition = GameObject.Find("7");
                    }
                    if (WhereTo == 8)
                    {
                        InventoryPosition = GameObject.Find("8");
                    }
                    if (WhereTo == 9)
                    {
                        InventoryPosition = GameObject.Find("9");
                    }
                    if (WhereTo == 10)
                    {
                        InventoryPosition = GameObject.Find("0");
                    }
                    WD2.transform.position = WD1.transform.position;
                    WD1.SetActive(false);
                    Cup1.transform.position = GameObject.Find("2").transform.position;
                    CupPosition = 2;
                    WhereTo = WhereTo + 1;

                }
                if (RayHit.transform.name == "ObjectWaterDispensor2")
                {
                    WD3.transform.position = WD2.transform.position;
                    WD2.SetActive(false);
                    Cup2.transform.position = Cup1.transform.position;
                    Cup1.SetActive(false);
                }
                if (RayHit.transform.name == "ObjectWaterDispensor3")
                {
                    WD4.transform.position = WD3.transform.position;
                    WD3.SetActive(false);
                    Cup3.transform.position = Cup2.transform.position;
                    Cup2.SetActive(false);
                }
                if (RayHit.transform.name == "ObjectWaterDispensor4")
                {
                    WD5.transform.position = WD4.transform.position;
                    WD4.SetActive(false);
                    Jill.transform.position = GoToForJill.transform.position;
                    CameraObject.transform.position = DummyCamera.transform.position;
                    DummyCamera.SetActive(false);
                    Cup4.transform.position = Cup3.transform.position;
                    Cup3.SetActive(false);
                    FourCupPosition = CupPosition;
                    Good.Play();
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
            if (WhereTo == 6)
            {
                InventoryPosition = GameObject.Find("6");
            }
            if (WhereTo == 7)
            {
                InventoryPosition = GameObject.Find("7");
            }
            if (WhereTo == 8)
            {
                InventoryPosition = GameObject.Find("8");
            }
            if (WhereTo == 9)
            {
                InventoryPosition = GameObject.Find("9");
            }
            if (WhereTo == 10)
            {
                InventoryPosition = GameObject.Find("0");
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
                    Camera1.transform.position = GameObject.Find("6").transform.position;
                    CameraObject.SetActive(false);
                    CameraPosition = 6;
                    WhereTo = WhereTo + 1;
                    Good.Play();
                }
                if (RayHit.transform.name == "ObjectPizza")
                {
                    Pizza1.transform.position = GameObject.Find("5").transform.position;
                    PizzaObject.SetActive(false);
                    PizzaPosition = 5;
                    WhereTo = WhereTo + 1;
                    Good.Play();
                }
                if (RayHit.transform.name == "ObjectBook")
                {
                    Book1.transform.position = GameObject.Find("1").transform.position;
                    BookObject.SetActive(false);
                    BookPosition = 1;
                    WhereTo = WhereTo + 1;
                    Good.Play();
                }
                if (RayHit.transform.name == "ObjectAngryEye")
                {
                    Eye1.transform.position = GameObject.Find("4").transform.position;
                    EyeObject.SetActive(false);
                    EyePosition = 4;
                    WhereTo = WhereTo + 1;
                    Good.Play();
                }
                if (RayHit.transform.name == "Globe")
                {
                    Globe1.transform.position = GameObject.Find("3").transform.position;
                    GlobeObject.SetActive(false);
                    GlobePosition = 3;
                    WhereTo = WhereTo + 1;
                    Good.Play();
                }
                if ((RayHit.transform.name == "Karen") && (CameraButtonOn == true))
                {
                    Karen1.transform.position = GameObject.Find("7").transform.position;
                    KarenPosition = 7;
                    WhereTo = WhereTo + 1;
                    DummyKaren.SetActive(true);
                    KarenObject.SetActive(false);
                    Good.Play();
                }
                if ((RayHit.transform.name == "Bob") && (CameraButtonOn == true))
                {
                    Bob1.transform.position = GameObject.Find("8").transform.position;
                    BobPosition = 8;
                    WhereTo = WhereTo + 1;
                    Good.Play();
                }
                if ((RayHit.transform.name == "Jill") && (CameraButtonOn == true))
                {
                    Jill1.transform.position = GameObject.Find("9").transform.position;
                    JillPosition = 9;
                    WhereTo = WhereTo + 1;
                    Good.Play();
                }
                if (RayHit.transform.name == "DummyObjectCamera")
                {
                    Emily.SetActive(false);
                    Emily.transform.position = GoToForEmily.transform.position;
                    Emily.SetActive(true);
                    Bad.Play();
                }
                if ((RayHit.transform.name == "Bob") && (KarenBookButtonOn == true))
                {
                    BobObject.SetActive(false);
                    Bob1.SetActive(false);
                    Good.Play();
                }
                if ((RayHit.transform.name == "LustLock") && (KarenBookButtonOn == true))
                {
                    LustLock.SetActive(false);
                    KarenBook1.SetActive(false);
                    Unlock.Play();
                }
                if ((RayHit.transform.name == "GluttonyLock") && (PizzaButtonOn == true))
                {
                    GluttonyLock.SetActive(false);
                    Pizza1.SetActive(false);
                    Unlock.Play();
                }
                if ((RayHit.transform.name == "GreedLock") && (CupButtonOn == true))
                {
                    GreedLock.SetActive(false);
                    Cup1.SetActive(false);
                    Unlock.Play();
                }
                if ((RayHit.transform.name == "WrathLock") && (EyeButtonOn == true))
                {
                    WrathLock.SetActive(false);
                    Eye1.SetActive(false);
                    Unlock.Play();
                }
                if ((RayHit.transform.name == "SlothLock") && (BobButtonOn == true))
                {
                    SlothLock.SetActive(false);
                    Bob1.SetActive(false);
                    Unlock.Play();
                }
                if ((RayHit.transform.name == "PrideLock") && (JillButtonOn == true))
                {
                    PrideLock.SetActive(false);
                    Jill1.SetActive(false);
                    Unlock.Play();
                }
                if ((RayHit.transform.name == "EnvyLock") && (GlobeButtonOn == true))
                {
                    EnvyLock.SetActive(false);
                    Globe1.SetActive(false);
                    Unlock.Play();
                }

            }
        }
    }
}
