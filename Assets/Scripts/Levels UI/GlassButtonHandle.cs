using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassButtonHandle : MonoBehaviour
{
    public static GlassButtonHandle instance;
    public GameObject blueGlasses;
    public GameObject greenGlasses;
    public GameObject redGlasses;
    public GameObject[] GlassesImages = new GameObject[3];
    public bool isBlueGActive = false, isGreenGActive = false, isRedGActive = false;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (!PauseResume.instance.isGamePaused)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                BlueGlassesFunc();
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                GreenGlassesFunc();
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                RedGlassesFunc();
            }
        }
    }
    public void BlueGlassesFunc()
    {
        if (!isBlueGActive)
        {
            GlassesImages[0].SetActive(true);
            blueGlasses.SetActive(true);
            isBlueGActive = true;
        }
        else if (isBlueGActive)
        {
            GlassesImages[0].SetActive(false);
            blueGlasses.SetActive(false);
            isBlueGActive = false;
        }
    }
    public void GreenGlassesFunc()
    {
        if (!isGreenGActive)
        {
            GlassesImages[1].SetActive(true);
            greenGlasses.SetActive(true);
            isGreenGActive = true;
        }
        else if (isGreenGActive)
        {
            GlassesImages[1].SetActive(false);
            greenGlasses.SetActive(false);
            isGreenGActive = false;
        }
    }
    public void RedGlassesFunc()
    {
        if (!isRedGActive)
        {
            GlassesImages[2].SetActive(true);
            redGlasses.SetActive(true);
            isRedGActive = true;
        }
        else if (isRedGActive)
        {
            GlassesImages[2].SetActive(false);
            redGlasses.SetActive(false);
            isRedGActive = false;
        }
    }
}
