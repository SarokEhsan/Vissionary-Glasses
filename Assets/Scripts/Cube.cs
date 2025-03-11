using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float horizontalInput, verticalInput, mouseHor, mouseVer;
    private float moveSpeed = 50.0f, rotationSpeed = 500.0f;

    private Rigidbody rb;
    public GameObject mainCamera;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.position = transform.position;
        MoveForwardBackward();
        MoveRightLeft();
        MoveUpDown();
        CameraRotate();
    }

    void MoveForwardBackward()
    {
        verticalInput = Input.GetAxis("Vertical");
        rb.AddRelativeForce(Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);
        //transform.Translate(Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);
    }
    void MoveRightLeft()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        rb.AddRelativeForce(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);
        //transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);
    }

    void MoveUpDown()
    {
        if (Input.GetKey(KeyCode.E))
        {
            rb.AddRelativeForce(Vector3.up * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddRelativeForce(Vector3.down *  moveSpeed * Time.deltaTime);
        }
    }

    void CameraRotate()
    {
        mouseHor = Input.GetAxis("Mouse X");
        mouseVer = Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.up * mouseHor * rotationSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.left * mouseVer * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
