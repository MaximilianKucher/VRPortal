using UnityEngine;

public class Gun : MonoBehaviour
{
    // The Camera object from the players FOV
    public Camera fpsCam;

    // Just to recognize a mouse pressed button
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot(true);
        }
        else if (Input.GetKeyDown("Fire3"))
        {
            Shoot(false);
        }
    }
    /// <summary>
    /// Raycast a shot. With the hit variable the position of the hit can be determind to spawn a portal. 
    /// </summary>
    /// <param name="bluePortal">To different between a left and the right click portal</param>
    void Shoot(bool bluePortal)
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
