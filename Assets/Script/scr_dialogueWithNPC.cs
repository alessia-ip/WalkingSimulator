using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
    public Text npcHintUIText;
    public string npcName;

    //for Sound effects
    public AudioSource soundPlayer;
    public AudioClip npcSOUND;


    bool dialogueActive = false;

    int startNum = 0;


    private void Update()
    {

        if(dialogueActive == true)
        {
            npcHintUI.TweenShut();
        }

        if (Input.GetMouseButtonDown(0) && dialogueActive == true)
        {

            startNum++;

            if (startNum >= dialogue.Length)
            {
                drifter.enabled = true;
                lookX.enabled = true;
                lookY.enabled = true;

                playerText.text = "";
                npcText.text = "";

                playerUI.TweenShut();
                npcUI.TweenShut();

                startNum = 0;

                dialogueActive = false;
            }
            else
            {
                npcHintUI.TweenShut();

                if (startNum % 2 == 0) // this will always be the NPC text
                {
                    soundPlayer.PlayOneShot(npcSOUND);

                    playerUI.TweenShut();
                    playerText.text = "";

                    npcUI.TweenOpen();
                    npcText.text = dialogue[startNum];

                    playerUI.TweenShut();
                    playerText.text = "";

                }
                else // this will always be the player text
                {
                    npcUI.TweenShut();
                    npcText.text = "";

                    playerUI.TweenOpen();
                    playerText.text = dialogue[startNum];

                    npcUI.TweenShut();
                    npcText.text = "";
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            Debug.Log("entered");
            npcHintUIText.text = npcName;
            npcHintUI.TweenOpen();
            npcHintUIButton.SetActive(true);

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.name == player.name)
        {

            if (Input.GetMouseButton(1) && dialogueActive == false)
            {

                npcHintUI.TweenShut();

                //Turns off player motion control
                drifter.enabled = false;
                lookX.enabled = false;
                lookY.enabled = false;

                //first line of dialogue should be from the NPC
                npcUI.TweenOpen();
                npcText.text = dialogue[0];

                //play NPC sound
                soundPlayer.PlayOneShot(npcSOUND);

                //set the dialogue to true
                dialogueActive = true;
            }

            if (dialogueActive == false)
            {
                playerUI.TweenShut();
                npcUI.TweenShut();
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        npcHintUI.TweenShut();
    }

}
