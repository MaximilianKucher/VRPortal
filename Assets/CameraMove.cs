using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private string mouseXInputName, mouseYInputName;
    [SerializeField] private float mouseSensitivity;

    [SerializeField] private Transform playerBody;

    private float xAxisClamp;

    public Vector3 position;

    public float movementSpeed = 0.2f;
    public float rotationSpeed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            position.x -= movementSpeed;
            transform.position = position;
        }
        if (Input.GetKey(KeyCode.A))
        {
            position.x += movementSpeed;
            transform.position = position;
        }
        if (Input.GetKey(KeyCode.S))
        {
            position.z += movementSpeed;
            transform.position = position;
        }
        if (Input.GetKey(KeyCode.W))
        {
            position.z -= movementSpeed;
            transform.position = position;
        }
        if (Input.GetMouseButtonDown(1))
        {
            CameraRotation();
        }
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;

        xAxisClamp += mouseY;

        if (xAxisClamp > 90.0f)
        {
            xAxisClamp = 90.0f;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(270.0f);
        }
        else if (xAxisClamp < -90.0f)
        {
            xAxisClamp = -90.0f;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(90.0f);
        }

        transform.Rotate(Vector3.left * mouseY);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void ClampXAxisRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }
}
