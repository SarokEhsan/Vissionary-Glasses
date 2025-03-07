using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassButtonHandle : MonoBehaviour
{
    public static GlassButtonHandle instance;
    public GameObject blueGlasses;
    public GameObject greenGlasses;
    public GameObject redGlasses;
    public GameObject[] activeTexts = new GameObject[3];
    public bool isBlueGActive = false, isGreenGActive = false, isRedGActive = false;

    private void Awake()
    {
        instance = this;
    }
    public void BlueButtonFunc()
    {
        if (!isBlueGActive)
        {
            activeTexts[0].SetActive(true);
            blueGlasses.SetActive(true);
            isBlueGActive = true;
        }
        else if (isBlueGActive)
        {
            activeTexts[0].SetActive(false);
            blueGlasses.SetActive(false);
            isBlueGActive = false;
        }
    }
    public void GreenButtonFunc()
    {
        if (!isGreenGActive)
        {
            activeTexts[1].SetActive(true);
            greenGlasses.SetActive(true);
            isGreenGActive = true;
        }
        else if (isGreenGActive)
        {
            activeTexts[1].SetActive(false);
            greenGlasses.SetActive(false);
            isGreenGActive = false;
        }
    }
    public void RedButtonFunc()
    {
        if (!isRedGActive)
        {
            activeTexts[2].SetActive(true);
            redGlasses.SetActive(true);
            isRedGActive = true;
        }
        else if (isRedGActive)
        {
            activeTexts[2].SetActive(false);
            redGlasses.SetActive(false);
            isRedGActive = false;
        }
    }
}
