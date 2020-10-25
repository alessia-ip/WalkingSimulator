using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scr_PlayerWalkingDialogue : MonoBehaviour
{

    public GameObject player;
    public scr_ItemTweener uiElement;
    public Text uiText;
    public string playerThought;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            uiElement.TweenOpen();
            uiText.text = playerThought;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == player.name)
        {
            uiText.text = "";
            uiElement.TweenShut();
            this.gameObject.SetActive(false);
        }
    }


}
