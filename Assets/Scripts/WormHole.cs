using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormHole : MonoBehaviour
{
    public GameObject otherPortal;
    public GameObject player;

    public float delay;


    private void Update()
    {
        if (delay >= 0f) delay -= Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("SAHSADASLKD");

        if (other.tag == "Player" && delay <= 0)
        {
            otherPortal.GetComponent<WormHole>().delay = 1f;


            /*
            other.transform.position = otherPortal.transform.position + otherPortal.transform.forward * 2;
            var spieler = player.GetComponent<PlayerMove>();
            var vec = otherPortal.transform.rotation.eulerAngles;
            Debug.Log(vec);
            if (vec.y == 90)
            {
                spieler.gravity = new Vector3(spieler.gravityValue, 0, 0);
                player.transform.rotation = Quaternion.Euler(0, 0, -90f);
                Debug.Log("1. " + spieler.gravity);
            }
            else if (vec.y == 270)
            {
                spieler.gravity = new Vector3(-spieler.gravityValue, 0, 0);
                Debug.Log("2. " + spieler.gravity);
            }
            else if (vec.y >= 178f && vec.y <= 182f)
            {
                spieler.gravity = new Vector3(0, 0, -spieler.gravityValue);
                Debug.Log("180° " + spieler.gravity);
            }
            else if (vec.x == 90)
            {
                spieler.gravity = new Vector3(0, -spieler.gravityValue, 0);
                Debug.Log("3. " + spieler.gravity);
            }
            else if (vec.x == 270)
            {
                spieler.gravity = new Vector3(0, spieler.gravityValue, 0);
                Debug.Log("4. " + spieler.gravity);
            }
            else if (vec.x >= -1f && vec.x <= 1f && vec.y >= -1f && vec.y <= 1f)
            {
                spieler.gravity = new Vector3(0, 0, spieler.gravityValue);
                Debug.Log("^Last. " + spieler.gravity);
            }*/

        }
    }
}
