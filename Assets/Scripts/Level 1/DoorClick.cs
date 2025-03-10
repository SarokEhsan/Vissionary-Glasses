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
                if (hit.transform.gameObject.tag == "Glasses")
                {
                    RayCollide();
                }
            }
        }
    }

    public void DoorFunc()
    {
        PauseResume.instance.isGamePaused = true;
        passwordInput.gameObject.SetActive(true);
    }

    void RayCollide()
    {
        rayCollide.gameObject.SetActive(true);
        StartCoroutine(rayCollideRoutine());
    }

    IEnumerator rayCollideRoutine()
    {
        yield return new WaitForSeconds(1.5f);
        rayCollide.gameObject.SetActive(false);
    }
}
