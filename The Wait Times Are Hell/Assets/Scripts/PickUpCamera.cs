using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PickUpCamera : MonoBehaviour
{
    public GameObject IS1DA;
    public GameObject IS2DA;
    public GameObject IS3DA;
    public GameObject IS4DA;
    public GameObject IS5DA;
    public GameObject IS6DA;
    public GameObject IS7DA;
    public GameObject IS8DA;
    public GameObject IS9DA;
    public GameObject IS10DA;
    public GameObject IS1A;
    public GameObject IS2A;
    public GameObject IS3A;
    public GameObject IS4A;
    public GameObject IS5A;
    public GameObject IS6A;
    public GameObject IS7A;
    public GameObject IS8A;
    public GameObject IS9A;
    public GameObject IS10A;

    public GameObject LustLock;
    public GameObject GluttonyLock;
    public GameObject GreedLock;
    public GameObject WrathLock;
    public GameObject SlothLock;
    public GameObject PrideLock;
    public GameObject EnvyLock;

    public bool LustOpen;
    public bool GluttonyOpen;
    public bool GreedOpen;
    public bool WrathOpen;
    public bool SlothOpen;
    public bool PrideOpen;
    public bool EnvyOpen;


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
    public GameObject BobPicObject;
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
        if ((PrideOpen == true) && (SlothOpen == true) && (EnvyOpen == true) && (GluttonyOpen == true) && (LustOpen == true) && (WrathOpen == true) && (GreedOpen == true))
        {
            SceneManager.LoadScene("You Win");
        }


        if (Input.GetKeyDown(CameraPosition.ToString()))
        {
            CameraButtonOn = true;
            IS6DA.SetActive(false);
            IS6A.SetActive(true);

            BookButtonOn = false;
            IS1DA.SetActive(true);
            IS1A.SetActive(false);

            KarenButtonOn = false;
            IS7DA.SetActive(true);
            IS7A.SetActive(false);

            KarenBookButtonOn = false;
            IS1DA.SetActive(true);
            IS1A.SetActive(false);

            PizzaButtonOn = false;
            IS5DA.SetActive(true);
            IS5A.SetActive(false);

            CupButtonOn = false;
            IS2DA.SetActive(true);
            IS2A.SetActive(false);

            EyeButtonOn = false;
            IS4DA.SetActive(true);
            IS4A.SetActive(false);

            BobButtonOn = false;
            IS8DA.SetActive(true);
            IS8A.SetActive(false);

            JillButtonOn = false;
            IS9DA.SetActive(true);
            IS9A.SetActive(false);

            GlobeButtonOn = false;
            IS3DA.SetActive(true);
            IS3A.SetActive(false);

        }
        if (Input.GetKeyDown(BookPosition.ToString()))
        {
            BookButtonOn = true;
            IS1DA.SetActive(false);
            IS1A.SetActive(true);

            IS6DA.SetActive(true);
            IS6A.SetActive(false);
            CameraButtonOn = false;

            PizzaButtonOn = false;
            IS5DA.SetActive(true);
            IS5A.SetActive(false);

            CupButtonOn = false;
            IS2DA.SetActive(true);
            IS2A.SetActive(false);

            EyeButtonOn = false;
            IS4DA.SetActive(true);
            IS4A.SetActive(false);

            BobButtonOn = false;
            IS8DA.SetActive(true);
            IS8A.SetActive(false);

            JillButtonOn = false;
            IS9DA.SetActive(true);
            IS9A.SetActive(false);

            GlobeButtonOn = false;
            IS3DA.SetActive(true);
            IS3A.SetActive(false);

        }
        if (Input.GetKeyDown(KarenPosition.ToString()))
        {
            KarenButtonOn = true;
            IS7DA.SetActive(false);
            IS7A.SetActive(true);

            IS6DA.SetActive(true);
            IS6A.SetActive(false);
            CameraButtonOn = false;

            PizzaButtonOn = false;
            IS5DA.SetActive(true);
            IS5A.SetActive(false);

            CupButtonOn = false;
            IS2DA.SetActive(true);
            IS2A.SetActive(false);

            EyeButtonOn = false;
            IS4DA.SetActive(true);
            IS4A.SetActive(false);

            BobButtonOn = false;
            IS8DA.SetActive(true);
            IS8A.SetActive(false);

            JillButtonOn = false;
            IS9DA.SetActive(true);
            IS9A.SetActive(false);

            GlobeButtonOn = false;
            IS3DA.SetActive(true);
            IS3A.SetActive(false);

        }
        if (Input.GetKeyDown(KarenBookPosition.ToString()))
        {
            KarenBookButtonOn = true;
            IS1DA.SetActive(false);
            IS1A.SetActive(true);

            IS6DA.SetActive(true);
            IS6A.SetActive(false);
            CameraButtonOn = false;

            PizzaButtonOn = false;
            IS5DA.SetActive(true);
            IS5A.SetActive(false);

            CupButtonOn = false;
            IS2DA.SetActive(true);
            IS2A.SetActive(false);

            EyeButtonOn = false;
            IS4DA.SetActive(true);
            IS4A.SetActive(false);

            BobButtonOn = false;
            IS8DA.SetActive(true);
            IS8A.SetActive(false);

            JillButtonOn = false;
            IS9DA.SetActive(true);
            IS9A.SetActive(false);

            GlobeButtonOn = false;
            IS3DA.SetActive(true);
            IS3A.SetActive(false);

        }
        if (Input.GetKeyDown(PizzaPosition.ToString()))
        {
            PizzaButtonOn = true;
            IS5DA.SetActive(false);
            IS5A.SetActive(true);

            IS6DA.SetActive(true);
            IS6A.SetActive(false);
            CameraButtonOn = false;

            BookButtonOn = false;
            IS1DA.SetActive(true);
            IS1A.SetActive(false);

            KarenButtonOn = false;
            IS7DA.SetActive(true);
            IS7A.SetActive(false);

            KarenBookButtonOn = false;
            IS1DA.SetActive(true);
            IS1A.SetActive(false);

            CupButtonOn = false;
            IS2DA.SetActive(true);
            IS2A.SetActive(false);

            EyeButtonOn = false;
            IS4DA.SetActive(true);
            IS4A.SetActive(false);

            BobButtonOn = false;
            IS8DA.SetActive(true);
            IS8A.SetActive(false);

            JillButtonOn = false;
            IS9DA.SetActive(true);
            IS9A.SetActive(false);

            GlobeButtonOn = false;
            IS3DA.SetActive(true);
            IS3A.SetActive(false);
        }
        if (Input.GetKeyDown(FourCupPosition.ToString()))
        {
            CupButtonOn = true;
            IS2DA.SetActive(false);
            IS2A.SetActive(true);

            IS6DA.SetActive(true);
            IS6A.SetActive(false);
            CameraButtonOn = false;

            BookButtonOn = false;
            IS1DA.SetActive(true);
            IS1A.SetActive(false);

            KarenButtonOn = false;
            IS7DA.SetActive(true);
            IS7A.SetActive(false);

            KarenBookButtonOn = false;
            IS1DA.SetActive(true);
            IS1A.SetActive(false);

            PizzaButtonOn = false;
            IS5DA.SetActive(true);
            IS5A.SetActive(false);

            EyeButtonOn = false;
            IS4DA.SetActive(true);
            IS4A.SetActive(false);

            BobButtonOn = false;
            IS8DA.SetActive(true);
            IS8A.SetActive(false);

            JillButtonOn = false;
            IS9DA.SetActive(true);
            IS9A.SetActive(false);

            GlobeButtonOn = false;
            IS3DA.SetActive(true);
            IS3A.SetActive(false);
        }
        if (Input.GetKeyDown(EyePosition.ToString()))
        {
            EyeButtonOn = true;
            IS4DA.SetActive(false);
            IS4A.SetActive(true);

            IS6DA.SetActive(true);
            IS6A.SetActive(false);
            CameraButtonOn = false;

            BookButtonOn = false;
            IS1DA.SetActive(true);
            IS1A.SetActive(false);

            KarenButtonOn = false;
            IS7DA.SetActive(true);
            IS7A.SetActive(false);

            KarenBookButtonOn = false;
            IS1DA.SetActive(true);
            IS1A.SetActive(false);

            PizzaButtonOn = false;
            IS5DA.SetActive(true);
            IS5A.SetActive(false);

            CupButtonOn = false;
            IS2DA.SetActive(true);
            IS2A.SetActive(false);

            BobButtonOn = false;
            IS8DA.SetActive(true);
            IS8A.SetActive(false);

            JillButtonOn = false;
            IS9DA.SetActive(true);
            IS9A.SetActive(false);

            GlobeButtonOn = false;
            IS3DA.SetActive(true);
            IS3A.SetActive(false);
        }
        if (Input.GetKeyDown(BobPosition.ToString()))
        {
            BobButtonOn = true;
            IS8DA.SetActive(false);
            IS8A.SetActive(true);

            IS6DA.SetActive(true);
            IS6A.SetActive(false);
            CameraButtonOn = false;

            BookButtonOn = false;
            IS1DA.SetActive(true);
            IS1A.SetActive(false);

            KarenButtonOn = false;
            IS7DA.SetActive(true);
            IS7A.SetActive(false);

            KarenBookButtonOn = false;
            IS1DA.SetActive(true);
            IS1A.SetActive(false);

            PizzaButtonOn = false;
            IS5DA.SetActive(true);
            IS5A.SetActive(false);

            CupButtonOn = false;
            IS2DA.SetActive(true);
            IS2A.SetActive(false);

            EyeButtonOn = false;
            IS4DA.SetActive(true);
            IS4A.SetActive(false);

            JillButtonOn = false;
            IS9DA.SetActive(true);
            IS9A.SetActive(false);

            GlobeButtonOn = false;
            IS3DA.SetActive(true);
            IS3A.SetActive(false);
        }
        if (Input.GetKeyDown(JillPosition.ToString()))
        {
            JillButtonOn = true;
            IS9DA.SetActive(false);
            IS9A.SetActive(true);

            IS6DA.SetActive(true);
            IS6A.SetActive(false);
            CameraButtonOn = false;

            BookButtonOn = false;
            IS1DA.SetActive(true);
            IS1A.SetActive(false);

            KarenButtonOn = false;
            IS7DA.SetActive(true);
            IS7A.SetActive(false);

            KarenBookButtonOn = false;
            IS1DA.SetActive(true);
            IS1A.SetActive(false);

            PizzaButtonOn = false;
            IS5DA.SetActive(true);
            IS5A.SetActive(false);

            CupButtonOn = false;
            IS2DA.SetActive(true);
            IS2A.SetActive(false);

            EyeButtonOn = false;
            IS4DA.SetActive(true);
            IS4A.SetActive(false);

            BobButtonOn = false;
            IS8DA.SetActive(true);
            IS8A.SetActive(false);

            GlobeButtonOn = false;
            IS3DA.SetActive(true);
            IS3A.SetActive(false);
        }
        if (Input.GetKeyDown(GlobePosition.ToString()))
        {
            GlobeButtonOn = true;
            IS3DA.SetActive(false);
            IS3A.SetActive(true);

            IS6DA.SetActive(true);
            IS6A.SetActive(false);
            CameraButtonOn = false;

            BookButtonOn = false;
            IS1DA.SetActive(true);
            IS1A.SetActive(false);

            KarenButtonOn = false;
            IS7DA.SetActive(true);
            IS7A.SetActive(false);

            KarenBookButtonOn = false;
            IS1DA.SetActive(true);
            IS1A.SetActive(false);

            PizzaButtonOn = false;
            IS5DA.SetActive(true);
            IS5A.SetActive(false);

            CupButtonOn = false;
            IS2DA.SetActive(true);
            IS2A.SetActive(false);

            EyeButtonOn = false;
            IS4DA.SetActive(true);
            IS4A.SetActive(false);

            BobButtonOn = false;
            IS8DA.SetActive(true);
            IS8A.SetActive(false);

            JillButtonOn = false;
            IS9DA.SetActive(true);
            IS9A.SetActive(false);
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
            KarenBook1.transform.position = GameObject.Find("1 (1)").transform.position;
            KarenBookPosition = 1;
            Karen1.SetActive(false);
            Book1.SetActive(false);
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
                if ((RayHit.transform.name == "Pic"))
                {
                    BobPicObject.SetActive(false);
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
                    Good.Play();
                    LustLock.SetActive(true);
                    PrideLock.SetActive(true);
                    EnvyLock.SetActive(true);
                    GluttonyLock.SetActive(true);
                    WrathLock.SetActive(true);
                    SlothLock.SetActive(true);
                    GreedLock.SetActive(true);
                }
                if ((RayHit.transform.name == "LustLock") && (KarenBookButtonOn == true))
                {
                    LustLock.SetActive(false);
                    KarenBook1.SetActive(false);
                    Unlock.Play();
                    LustOpen = true;
                }
                if ((RayHit.transform.name == "GluttonyLock") && (PizzaButtonOn == true))
                {
                    GluttonyLock.SetActive(false);
                    Pizza1.SetActive(false);
                    Unlock.Play();
                    GluttonyOpen = true;
                }
                if ((RayHit.transform.name == "GreedLock") && (CupButtonOn == true))
                {
                    GreedLock.SetActive(false);
                    Cup1.SetActive(false);
                    Unlock.Play();
                    GreedOpen = true;
                }
                if ((RayHit.transform.name == "WrathLock") && (EyeButtonOn == true))
                {
                    WrathLock.SetActive(false);
                    Eye1.SetActive(false);
                    Unlock.Play();
                    WrathOpen = true;
                }
                if ((RayHit.transform.name == "SlothLock") && (BobButtonOn == true))
                {
                    SlothLock.SetActive(false);
                    Bob1.SetActive(false);
                    Unlock.Play();
                    SlothOpen = true;
                }
                if ((RayHit.transform.name == "PrideLock") && (JillButtonOn == true))
                {
                    PrideLock.SetActive(false);
                    Jill1.SetActive(false);
                    Unlock.Play();
                    PrideOpen = true;
                }
                if ((RayHit.transform.name == "EnvyLock") && (GlobeButtonOn == true))
                {
                    EnvyLock.SetActive(false);
                    Globe1.SetActive(false);
                    Unlock.Play();
                    EnvyOpen = true;
                }

            }
        }
    }
}
