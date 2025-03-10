using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassButtonHandle : MonoBehaviour
{
    public static GlassButtonHandle instance;
    public GameObject blueGlasses;
    public GameObject greenGlasses;
    public GameObject redGlasses;
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
            blueGlasses.SetActive(true);
            isBlueGActive = true;
        }
        else if (isBlueGActive)
        {
            blueGlasses.SetActive(false);
            isBlueGActive = false;
        }
    }
    public void GreenGlassesFunc()
    {
        if (!isGreenGActive)
        {
            greenGlasses.SetActive(true);
            isGreenGActive = true;
        }
        else if (isGreenGActive)
        {
            greenGlasses.SetActive(false);
            isGreenGActive = false;
        }
    }
    public void RedGlassesFunc()
    {
        if (!isRedGActive)
        {
            redGlasses.SetActive(true);
            isRedGActive = true;
        }
        else if (isRedGActive)
        {
            redGlasses.SetActive(false);
            isRedGActive = false;
        }
    }
}
