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
    public GameObject hintUIParent;

    private void OnTriggerEnter(Collider other)
    {


        if(other.name == player.name)
        {
            Debug.Log("entered");
           // hintUItext.text = "Document";
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == player.name)
        {
            if (Input.GetMouseButton(1))
            {
                //hintUIParent.SetActive(false);
                uiElement.TweenOpen();
                uiText.text = itemDescription;
            } else
            {
                uiText.text = "";
                uiElement.TweenShut();
            }
        }

    }

}
