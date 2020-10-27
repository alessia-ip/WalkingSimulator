using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_KeyObjectDialogue : MonoBehaviour
{
    public GameObject player;
    public scr_ItemTweener uiElement;
    public Text uiText;
    public string itemDescription;
    public Text hintUItext;
    public GameObject hintUIbutton;
    public GameObject hintUIParent;
    public string hintNewText;

    public AudioSource soundPlayer;
    public AudioClip playerSound;
    bool audioPlayed = false;

    private void OnTriggerEnter(Collider other)
    {


        if(other.name == player.name)
        {
            uiElement.gameObject.SetActive(true);
            Debug.Log("entered");
            hintUItext.text = hintNewText ;
            hintUIbutton.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == player.name)
        {
            if (Input.GetMouseButton(1))
            {
                hintUIParent.SetActive(false);
                uiElement.TweenOpen();
                uiText.text = itemDescription;
                if(audioPlayed == false){
                    soundPlayer.PlayOneShot(playerSound);
                    audioPlayed = true;
                }
            } else
            {
                uiText.text = "";
                uiElement.TweenShut();
                audioPlayed = false;

            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == player.name)
        {
            uiElement.TweenShut();
            uiElement.gameObject.SetActive(false);
        }
    }

}
