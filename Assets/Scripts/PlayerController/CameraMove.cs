using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private float horizontalInput, verticalInput, mouseHor, mouseVer;
    private float moveSpeed = 5.0f, rotationSpeed = 500.0f;

    // Update is called once per frame
    void Update()
    {
        var PR = PauseResume.instance;
        if (!PR.isGamePaused)
        {
            MoveForwardBackward();
            MoveRightLeft();
            CameraRotate();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                AdjustLook();
            }
        }
        
    }

    void MoveForwardBackward()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);
    }
    void MoveRightLeft()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);
    }
    void CameraRotate()
    {
        mouseHor = Input.GetAxis("Mouse X");
        mouseVer = Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.up * mouseHor * rotationSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.left * mouseVer * rotationSpeed * Time.deltaTime, Space.Self);
    }

    void AdjustLook()
    {
        gameObject.transform.LookAt(Vector3.forward);
    }
}
