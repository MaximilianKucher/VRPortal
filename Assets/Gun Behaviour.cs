using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class GunBehaviour : MonoBehaviour
{
    //TODO bind action (here Teleport) to controller
    void Update()
    {
        if (SteamVR_Actions.default_Teleport.GetStateDown(SteamVR_Input_Sources.Any))
        {
            print("Trigger down");
        }
    }
}
