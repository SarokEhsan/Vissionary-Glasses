using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorClick : MonoBehaviour
{
    public TMP_InputField passwordInput;
    public TextMeshProUGUI rayCollide;
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
                if (hit.transform.gameObject.name == "Desk")
                {
                    GameObject.Find("Desk Con").transform.Translate(Vector3.left * 0.28f, Space.World);
                    //hit.transform.gameObject.transform.Translate(Vector3.left * 0.28f, Space.World);
                }
                Debug.Log(hit.transform.gameObject.name);
            }
        }
    }

    public void DoorFunc()
    {
        PauseResume.instance.isGamePaused = true;
        passwordInput.gameObject.SetActive(true);
    }
}
