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
    [SerializeField] private string horizontalInputName;
    [SerializeField] private string verticalInputName;
    [SerializeField] private float movementSpeed;

    private Vector3 position;
    public float gravityValue = 2 * -9.81f;
    public Vector3 gravity = new Vector3(0, 2 * -9.81f, 0);
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Smoothed the movement of the player with variable Input Methods.
    /// </summary>
    void Update()
    {
        float horizInput = Input.GetAxis(horizontalInputName) * movementSpeed;
        float vertInput = Input.GetAxis(verticalInputName) * movementSpeed;

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        transform.position += (forwardMovement + rightMovement);
    }

    private void FixedUpdate()
    {
        rb.AddForce(gravity);
    }
}
