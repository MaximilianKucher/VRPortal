using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Player or object running into the portal
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
    }
}
