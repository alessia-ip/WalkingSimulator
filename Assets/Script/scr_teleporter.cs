using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_teleporter : MonoBehaviour
{
    //the place the player is teleporting to 
    public GameObject teleportENDPOINT;

    //the player character
    public GameObject playerObject;

    private void OnTriggerEnter(Collider other)
    {
        //if the player enters the trigger, teleport them to that trigger's assigned endpoint
        if(other.gameObject == playerObject)
        {
            playerObject.GetComponent<CharacterController>().enabled = false;
            playerObject.transform.position = teleportENDPOINT.transform.position;
            playerObject.GetComponent<CharacterController>().enabled = true;
        }
    }
}
