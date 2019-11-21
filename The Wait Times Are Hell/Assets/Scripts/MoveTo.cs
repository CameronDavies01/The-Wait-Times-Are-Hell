using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public Animator EmilyMove;
    public string Position;
    public GameObject BobScreen;
    public GameObject KarenScreen;
    public GameObject JillScreen;

    public GameObject ArrowUp;
    public GameObject ArrowDown;
    public GameObject ArrowLeft;
    public GameObject ArrowRight;

    // Start is called before the first frame update
    void Start()
    {
        Position = "1";
        EmilyMove = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // From the back
        if (Position == ("1"))
        {
            ArrowUp.SetActive(true);
            ArrowDown.SetActive(true);
            ArrowLeft.SetActive(false);
            ArrowRight.SetActive(false);
        }
        if ((Input.GetButtonDown("Down")) && (Position == ("1")))
        {
            EmilyMove.Play("EmilyBTC");
            StartCoroutine(AnimationBuffer2());
        }
        if ((Input.GetButtonDown("Up")) && (Position == ("1")))
        {
            EmilyMove.Play("EmilyBTBO");
            StartCoroutine(AnimationBuffer15());
        }

        // From the center when facing the back
        if (Position == ("2"))
        {
            ArrowUp.SetActive(true);
            ArrowDown.SetActive(false);
            ArrowLeft.SetActive(true);
            ArrowRight.SetActive(true);
        }
        if ((Input.GetButtonDown("Right")) && (Position == ("2")))
        {
            EmilyMove.Play("EmilyTurn1");
            StartCoroutine(AnimationBuffer3());
        }
        if ((Input.GetButtonDown("Up")) && (Position == ("2")))
        {
            EmilyMove.Play("EmilyCTB");
            StartCoroutine(AnimationBuffer1());
        }
        if ((Input.GetButtonDown("Left")) && (Position == ("2")))
        {
            EmilyMove.Play("EmilyTurn2");
            StartCoroutine(AnimationBuffer4());
        }
        // From the center when facing the left
        if (Position == ("2"))
        {
            ArrowUp.SetActive(true);
            ArrowDown.SetActive(false);
            ArrowLeft.SetActive(true);
            ArrowRight.SetActive(true);
        }
        if ((Input.GetButtonDown("Left")) && (Position == ("3")))
        {
            EmilyMove.Play("EmilyTurn7");
            StartCoroutine(AnimationBuffer2());
        }
        if ((Input.GetButtonDown("Right")) && (Position == ("3")))
        {
            EmilyMove.Play("EmilyTurn8");
            StartCoroutine(AnimationBuffer5());
        }
        if ((Input.GetButtonDown("Up")) && (Position == ("3")))
        {
            EmilyMove.Play("EmilyCTL");
            StartCoroutine(AnimationBuffer7());
        }
        // From the center when facing the right
        if (Position == ("3"))
        {
            ArrowUp.SetActive(true);
            ArrowDown.SetActive(false);
            ArrowLeft.SetActive(true);
            ArrowRight.SetActive(true);
        }
        if ((Input.GetButtonDown("Left")) && (Position == ("4")))
        {
            EmilyMove.Play("EmilyTurn3");
            StartCoroutine(AnimationBuffer5());
        }
        if ((Input.GetButtonDown("Right")) && (Position == ("4")))
        {
            EmilyMove.Play("EmilyTurn4");
            StartCoroutine(AnimationBuffer2());
        }
        if ((Input.GetButtonDown("Up")) && (Position == ("4")))
        {
            EmilyMove.Play("EmilyCTR");
            StartCoroutine(AnimationBuffer11());
        }

        // From the center when facing the front
        if (Position == ("4"))
        {
            ArrowUp.SetActive(true);
            ArrowDown.SetActive(false);
            ArrowLeft.SetActive(true);
            ArrowRight.SetActive(true);
        }
        if ((Input.GetButtonDown("Right")) && (Position == ("5")))
        {
            EmilyMove.Play("EmilyTurn5");
            StartCoroutine(AnimationBuffer4());
        }
        if ((Input.GetButtonDown("Left")) && (Position == ("5")))
        {
            EmilyMove.Play("EmilyTurn6");
            StartCoroutine(AnimationBuffer3());
        }
        if ((Input.GetButtonDown("Up")) && (Position == ("5")))
        {
            EmilyMove.Play("EmilyCTF");
            StartCoroutine(AnimationBuffer6());
        }

        // From Karen
        if (Position == ("5"))
        {
            ArrowUp.SetActive(true);
            ArrowDown.SetActive(false);
            ArrowLeft.SetActive(false);
            ArrowRight.SetActive(false);
        }
        if ((Input.GetButtonDown("Down")) && (Position == ("6")))
        {
            EmilyMove.Play("EmilyFTC");
            StartCoroutine(AnimationBuffer5());
        }
        // From the left
        if (Position == ("6"))
        {
            ArrowUp.SetActive(false);
            ArrowDown.SetActive(true);
            ArrowLeft.SetActive(false);
            ArrowRight.SetActive(false);
        }
        if ((Input.GetButtonDown("Down")) && (Position == ("7")))
        {
            EmilyMove.Play("EmilyLTC");
            StartCoroutine(AnimationBuffer3());
        }
        if ((Input.GetButtonDown("Up")) && (Position == ("7")))
        {
            EmilyMove.Play("EmilyLTLF");
            StartCoroutine(AnimationBuffer8());
        }
        if ((Input.GetButtonDown("Left")) && (Position == ("7")))
        {
            EmilyMove.Play("EmilyLTW1");
            StartCoroutine(AnimationBuffer9());
        }
        if ((Input.GetButtonDown("Right")) && (Position == ("7")))
        {
            EmilyMove.Play("EmilyLTW2");
            StartCoroutine(AnimationBuffer10());
        }
        // From the front
        if (Position == ("7"))
        {
            ArrowUp.SetActive(false);
            ArrowDown.SetActive(true);
            ArrowLeft.SetActive(false);
            ArrowRight.SetActive(false);
        }
        if ((Input.GetButtonDown("Down")) && (Position == ("8")))
        {
            EmilyMove.Play("EmilyLFTL");
            StartCoroutine(AnimationBuffer7());
        }

        // From window 1
        if (Position == ("8"))
        {
            ArrowUp.SetActive(false);
            ArrowDown.SetActive(true);
            ArrowLeft.SetActive(false);
            ArrowRight.SetActive(false);
        }
        if ((Input.GetButtonDown("Down")) && (Position == ("9")))
        {
            EmilyMove.Play("EmilyW1TL");
            StartCoroutine(AnimationBuffer7());
        }

        // From window 2
        if (Position == ("9"))
        {
            ArrowUp.SetActive(false);
            ArrowDown.SetActive(true);
            ArrowLeft.SetActive(false);
            ArrowRight.SetActive(false);
        }
        if ((Input.GetButtonDown("Down")) && (Position == ("10")))
        {
            EmilyMove.Play("EmilyW2TL");
            StartCoroutine(AnimationBuffer7());
        }

        // From the right
        if (Position == ("10"))
        {
            ArrowUp.SetActive(true);
            ArrowDown.SetActive(true);
            ArrowLeft.SetActive(true);
            ArrowRight.SetActive(true);
        }
        if ((Input.GetButtonDown("Down")) && (Position == ("11")))
        {
            EmilyMove.Play("EmilyRTC");
            StartCoroutine(AnimationBuffer4());
        }
        if ((Input.GetButtonDown("Up")) && (Position == ("11")))
        {
            EmilyMove.Play("EmilyRTRF");
            StartCoroutine(AnimationBuffer12());
        }
        if ((Input.GetButtonDown("Left")) && (Position == ("11")))
        {
            EmilyMove.Play("EmilyRTW3");
            StartCoroutine(AnimationBuffer13());
        }
        if ((Input.GetButtonDown("Right")) && (Position == ("11")))
        {
            EmilyMove.Play("EmilyRTW4");
            StartCoroutine(AnimationBuffer14());
        }

        // From Jill
        if (Position == ("12"))
        {
            ArrowUp.SetActive(false);
            ArrowDown.SetActive(true);
            ArrowLeft.SetActive(false);
            ArrowRight.SetActive(false);
        }
        if ((Input.GetButtonDown("Down")) && (Position == ("12")))
        {
            EmilyMove.Play("EmilyRFTR");
            StartCoroutine(AnimationBuffer11());
        }

        // From window 3
        if (Position == ("13"))
        {
            ArrowUp.SetActive(false);
            ArrowDown.SetActive(true);
            ArrowLeft.SetActive(false);
            ArrowRight.SetActive(false);
        }
        if ((Input.GetButtonDown("Down")) && (Position == ("13")))
        {
            EmilyMove.Play("EmilyW3TR");
            StartCoroutine(AnimationBuffer11());
        }

        // From window 4
        if (Position == ("14"))
        {
            ArrowUp.SetActive(false);
            ArrowDown.SetActive(true);
            ArrowLeft.SetActive(false);
            ArrowRight.SetActive(false);
        }
        if ((Input.GetButtonDown("Down")) && (Position == ("14")))
        {
            EmilyMove.Play("EmilyW4TR");
            StartCoroutine(AnimationBuffer11());
        }

        // From Bob
        if (Position == ("15"))
        {
            ArrowUp.SetActive(false);
            ArrowDown.SetActive(true);
            ArrowLeft.SetActive(false);
            ArrowRight.SetActive(false);
        }
        if ((Input.GetButtonDown("Down")) && (Position == ("15")))
        {
            EmilyMove.Play("EmilyBOTB");
            StartCoroutine(AnimationBuffer1());
        }

        if (Position == ("15"))
        {
            BobScreen.SetActive(true);
        }
        else
        {
            BobScreen.SetActive(false);

        }

        if (Position == ("6"))
        {
            KarenScreen.SetActive(true);
        }
        else
        {
            KarenScreen.SetActive(false);

        }

        if (Position == ("12"))
        {
            JillScreen.SetActive(true);
        }
        else
        {
            JillScreen.SetActive(false);

        }
    }
    IEnumerator AnimationBuffer1()
    {
        yield return new WaitForSeconds(1);
        Position = ("1");
    }
    IEnumerator AnimationBuffer2()
    {
        yield return new WaitForSeconds(1);
        Position = ("2");
    }
    IEnumerator AnimationBuffer3()
    {
        yield return new WaitForSeconds(1);
        Position = ("3");
    }
    IEnumerator AnimationBuffer4()
    {
        yield return new WaitForSeconds(1);
        Position = ("4");
    }
    IEnumerator AnimationBuffer5()
    {
        yield return new WaitForSeconds(1);
        Position = ("5");
    }
    IEnumerator AnimationBuffer6()
    {
        yield return new WaitForSeconds(1);
        Position = ("6");
    }
    IEnumerator AnimationBuffer7()
    {
        yield return new WaitForSeconds(1);
        Position = ("7");
    }
    IEnumerator AnimationBuffer8()
    {
        yield return new WaitForSeconds(1);
        Position = ("8");
    }
    IEnumerator AnimationBuffer9()
    {
        yield return new WaitForSeconds(1);
        Position = ("9");
    }
    IEnumerator AnimationBuffer10()
    {
        yield return new WaitForSeconds(1);
        Position = ("10");
    }
    IEnumerator AnimationBuffer11()
    {
        yield return new WaitForSeconds(1);
        Position = ("11");
    }
    IEnumerator AnimationBuffer12()
    {
        yield return new WaitForSeconds(1);
        Position = ("12");
    }
    IEnumerator AnimationBuffer13()
    {
        yield return new WaitForSeconds(1);
        Position = ("13");
    }
    IEnumerator AnimationBuffer14()
    {
        yield return new WaitForSeconds(1);
        Position = ("14");
    }
    IEnumerator AnimationBuffer15()
    {
        yield return new WaitForSeconds(1);
        Position = ("15");
    }
    IEnumerator AnimationBuffer16()
    {
        yield return new WaitForSeconds(1);
        Position = ("16");
    }
    IEnumerator AnimationBuffer17()
    {
        yield return new WaitForSeconds(1);
        Position = ("17");
    }
}
