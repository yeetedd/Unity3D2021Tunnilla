using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    private float xRotation = 0f;

    float mouseX;
    float mouseY;
    float minXAngle = -90f;
    float minYAngle = 90f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, minXAngle, minYAngle);

        Vector3 rotationInEuler = transform.rotation.eulerAngles;
        transform.localRotation = Quaternion.Euler(xRotation, rotationInEuler.y, 0f);

        transform.Rotate(Vector3.up * mouseX);
    }
}
