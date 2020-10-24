using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scr_dialogueWithNPC : MonoBehaviour
{
    //JUST AN EXTRA COLLIDER - NOT THE PLAYER OBJECT
    public GameObject player;

    //scripts that need to be turned off
    public FirstPersonDrifter drifter;
    public MouseLook lookX;
    public MouseLook lookY;

    //text tweeners
    public scr_ItemTweener playerUI;
    public Text playerText;    
    public scr_ItemTweener npcUI;
    public Text npcText;
    public string[] dialogue;

    //the hint for what the player should do to proceed
    public scr_ItemTweener npcHintUI;
    public GameObject npcHintUIButton;
    public GameObject npcHintUIText;


    bool dialogueActive = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            Debug.Log("entered");
            npcHintUI.TweenOpen();
            npcHintUIButton.SetActive(true);
            npcHintUIButton.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.name == player.name)
        {

            if (Input.GetMouseButton(1))
            {

            }


        }
    }

}
