using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVisibility : MonoBehaviour
{
    public GameObject[] objectDivisions = new GameObject[7];
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var GBH = GlassButtonHandle.instance;
        if (GBH.isBlueGActive && !GBH.isGreenGActive && !GBH.isRedGActive)
        {
            objectDivisions[0].SetActive(true);
        }
        else { objectDivisions[0].SetActive(false); }
        if (!GBH.isBlueGActive && GBH.isGreenGActive && !GBH.isRedGActive)
        {
            objectDivisions[1].SetActive(true);
        }
        else { objectDivisions[1].SetActive(false); }
        if (!GBH.isBlueGActive && !GBH.isGreenGActive && GBH.isRedGActive)
        {
            objectDivisions[2].SetActive(true);
        }
        else { objectDivisions[2].SetActive(false); }
        if (GBH.isBlueGActive && GBH.isGreenGActive && !GBH.isRedGActive)
        {
            objectDivisions[3].SetActive(true);
        }
        else { objectDivisions[3].SetActive(false); }
        if (!GBH.isBlueGActive && GBH.isGreenGActive && GBH.isRedGActive)
        {
            objectDivisions[4].SetActive(true);
        }
        else { objectDivisions[4].SetActive(false); }
        if (GBH.isBlueGActive && !GBH.isGreenGActive && GBH.isRedGActive)
        {
            objectDivisions[5].SetActive(true);
        }
        else { objectDivisions[5].SetActive(false); }
        if (GBH.isBlueGActive && GBH.isGreenGActive && GBH.isRedGActive)
        {
            objectDivisions[6].SetActive(true);
        }
        else { objectDivisions[6].SetActive(false); }
    }

    void Visibile()
    {

    }
}
