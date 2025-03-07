using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorClick : MonoBehaviour
{
    public TMP_InputField passwordInput;

    // Update is called once per frame
    void Update()
    {
        DoorRayDetection();
    }

    void DoorRayDetection()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.transform.gameObject.name == "Door")
                {
                    DoorFunc();
                }
            }
        }
    }

    public void DoorFunc()
    {
        PauseResume.instance.isGamePaused = true;
        passwordInput.gameObject.SetActive(true);
    }
}
