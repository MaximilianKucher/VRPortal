using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormHole : MonoBehaviour
{
    public GameObject otherPortal;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = otherPortal.transform.position + otherPortal.transform.forward * 2;
            var spieler = player.GetComponent<PlayerMove>();
            Debug.Log(otherPortal.transform.rotation);
        }
    }
}
