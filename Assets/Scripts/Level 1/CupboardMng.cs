using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupboardMng : MonoBehaviour
{
    bool isRightDoorOpened, isLeftDoorOpened;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform.gameObject.name == "trn_CupboardDoor_Left")
                {
                    if (!isRightDoorOpened)
                    {
                        hit.transform.gameObject.transform.Rotate(Vector3.forward, 90.0f);
                        isRightDoorOpened = true;
                    }
                    else
                    {
                        hit.transform.gameObject.transform.Rotate(Vector3.forward, -90.0f);
                        isRightDoorOpened = false;
                    }
                }
                if (hit.transform.gameObject.name == "trn_CupboardDoor_Right")
                {
                    if (!isLeftDoorOpened)
                    {
                        hit.transform.gameObject.transform.Rotate(Vector3.forward, -90.0f);
                        isLeftDoorOpened = true;
                    }
                    else
                    {
                        hit.transform.gameObject.transform.Rotate(Vector3.forward, 90.0f);
                        isLeftDoorOpened = false;
                    }
                }
            }
        }
    }
}
