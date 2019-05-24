using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private string mouseXInputName, mouseYInputName;
    [SerializeField] private float mouseSensitivity;

    private float xAxisClamp;

    private Vector3 position;
    private Vector3 rotation;

    public float movementSpeed = 0.2f;
    public float rotationSpeed = 0.2f;

    void Update()
    {
        position = this.transform.position;
        if (Input.GetKey(KeyCode.D))
        {
            position.x += movementSpeed;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.A))
        {
            position.x -= movementSpeed;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.S))
        {
            position.z -= movementSpeed;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.W))
        {
            position.z += movementSpeed;
            this.transform.position = position;
        }
        /*

        if (Input.GetMouseButtonDown(1))    //right mouse button
        {
             //CameraRotation();
            rotation = new Vector3(Input.GetAxis("Mouse Y")* 10, Input.GetAxis("Mouse X")*10, 0f);
          
            print("Rotation: " + rotation);
            if (Input.GetAxis("Mouse X") < 0)
            {
               // transform.Rotate(rotation * Time.deltaTime * rotationSpeed);
                transform.Rotate(Vector3.up * rotationSpeed);
            }
            else
            {
                //transform.Rotate(rotation * Time.deltaTime * -rotationSpeed);
                  transform.Rotate(Vector3.up * -rotationSpeed);
            }
                
      
        }*/
    }

    //TODO
    private void CameraRotation()
    {
        float mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;
        print("Y " + mouseY);
        print("X " + mouseX);
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
        //print(mouseX);
        //this.transform.Rotate(Vector3.left * mouseY);
        //this.transform.Rotate(Vector3.up * mouseX);
    }

    private void ClampXAxisRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        this.transform.eulerAngles = eulerRotation;
    }


}
