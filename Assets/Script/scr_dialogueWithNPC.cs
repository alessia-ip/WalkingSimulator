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
    public AudioClip playerSound;

    //for next indicator
    public GameObject playerNext;
    public GameObject npcNext;

    bool dialogueActive = false;

    int startNum = 0;

    bool clicked = false;

    private void Update()
    {

        if(clicked == true)
        {
            playerNext.SetActive(false);
            npcNext.SetActive(false);
        } else
        {
            playerNext.SetActive(true);
            npcNext.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) && dialogueActive == true && clicked == false && startNum != 0)
        {


            if (startNum >= dialogue.Length)
            {
                drifter.enabled = true;
                lookX.enabled = true;
                lookY.enabled = true;

                playerText.text = "";
                npcText.text = "";

                playerUI.TweenShut();
                npcUI.TweenShut();
                npcHintUI.gameObject.SetActive(true);

                startNum = 0;

                dialogueActive = false;
            }
            else
            {
                npcHintUI.TweenShut();

                if (startNum % 2 == 0) // this will always be the NPC text
                {

                    Debug.Log("NPC Dialogue Opening");
                    playerUI.TweenShut();
                    soundPlayer.PlayOneShot(npcSOUND);
                    npcUI.TweenOpen();
                    npcText.text = dialogue[startNum];
                    clicked = true;



                }
                else // this will always be the player text
                {

                    Debug.Log("PC Dialogue Opening");
                    npcUI.TweenShut();
                    soundPlayer.PlayOneShot(playerSound);
                    playerUI.TweenOpen();
                    playerText.text = dialogue[startNum];
                    clicked = true;


                }

                startNum++;

                StartCoroutine(ClickReset());
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
      

        if (other.name == player.name && dialogueActive == false)
        {
            npcHintUI.gameObject.SetActive(true);

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
                clicked = true;
                StartCoroutine(ClickReset());

                Debug.Log("Start Dialogue Opening");
                npcHintUI.TweenShut();
                npcHintUI.gameObject.SetActive(false);

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
                
                startNum++;
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
       if(other.name == player.name)
        {
            npcHintUI.TweenShut();
            npcHintUI.gameObject.SetActive(false);
        }
    }

    IEnumerator ClickReset()
    {
        yield return new WaitForSeconds(1f);
        clicked = false;
    }

}
