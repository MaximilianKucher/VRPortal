using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;       //Public variable to store a reference to the player game object
    public Vector3 offset;         //Private variable to store the offset distance between the player and camera

    public float sensitivity = 10f;
    void Update()
    {
        //var c = Camera.main.transform;
        //c.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0);
        //c.Rotate(-Input.GetAxis("Mouse Y") * sensitivity, 0, 0);
        //c.Rotate(0, 0, -Input.GetAxis("QandE") * 90 * Time.deltaTime);
        //if (Input.GetMouseButtonDown(0))
            //Cursor.lockState = CursorLockMode.Locked;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        //transform.LookAt(player.transform.position);
    }
}