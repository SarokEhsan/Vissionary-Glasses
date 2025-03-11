using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBoundaryLvl1 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (PauseResume.instance.isGamePaused == false)
        {
            XBound();
            YBound();
            ZBound();
        }
    }

    void XBound()
    {
        float maxXBound = 2.0f;
        if (transform.position.x < -maxXBound)
        {
            transform.position = new Vector3(-maxXBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > maxXBound)
        {
            transform.position = new Vector3(maxXBound, transform.position.y, transform.position.z);
        }
    }

    void YBound()
    {
        float maxYBound = 2.0f, minYBound = 2.0f;
        if (transform.position.y < minYBound)
        {
            transform.position = new Vector3(transform.position.x, minYBound, transform.position.z);
        }
        if (transform.position.y > maxYBound)
        {
            transform.position = new Vector3(transform.position.x, maxYBound, transform.position.z);
        }
    }

    void ZBound()
    {
        float maxZBound = 2.0f;
        if (transform.position.z < -maxZBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -maxZBound);
        }
        if (transform.position.z > maxZBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, maxZBound);
        }
    }
}
