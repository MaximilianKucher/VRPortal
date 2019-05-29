using UnityEngine;

public class Gun : MonoBehaviour
{
    // The Camera object from the players FOV
    public Camera fpsCam;

    // Portals, very bad coding, I know, I know (^:
    public GameObject bluePortal; // left trigger
    public GameObject orangePortal; // right trigger

    // Just to recognize a mouse pressed button
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            Shoot(true);
        }
        else if (Input.GetButtonDown("Fire2")) // KeyDown und Fire3?
        {
            Shoot(false);
        }
    }
    /// <summary>
    /// Raycast a shot. With the hit variable the position of the hit can be determind to spawn a portal. 
    /// </summary>
    /// <param name="p_bluePortal">To different between a left and the right click portal</param>
    void Shoot(bool p_bluePortal)
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
        {
            if (hit.transform.tag != "Player")
            {
                (p_bluePortal ? bluePortal : orangePortal).transform.position = hit.point;
                (p_bluePortal ? bluePortal : orangePortal).transform.rotation = Quaternion.LookRotation(hit.normal);
               
            }

            //Debug.Log(hit.transform.name);
        }
    }
}
