using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayCameraUI : MonoBehaviour
{

    public string myString;
    private Text myText;
    public float fadeTime;
    private bool displayInfo;
    public KeyCode pickUp;
    public GameObject interactObj;

    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("UI").GetComponent<Text> ();
        myText.color = Color.clear;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(pickUp) && displayInfo)
        {
            ItemPickUp();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        displayInfo = true;
        myText.text = myString;
        myText.color = Color.white;
    }

    private void OnTriggerExit(Collider other)
    {
        displayInfo = false;
        myText.color = Color.clear;
    }

    /*void OnMouseOver()
    {
        displayInfo = true;
    }

    void OnMouseExit()
    {
        displayInfo = false;
    }*/

    void FadeText()
    {
        if (displayInfo)
        {
            myText.text = myString;
            myText.color = Color.white;
           // myText.color = Color.Lerp(myText.color, Color.white, fadeTime * Time.deltaTime);
        }
        else
        {
            
            myText.color = Color.clear;
            //myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }

    void ItemPickUp()
    {
        globalVarStorage.hasCamera = true;
        displayGlobalUI.uiNum = "zoomHowTo";
        displayInfo = false;
        myText.color = Color.clear;
        if(myText.color == Color.clear)
        {
            interactObj.SetActive(false);
        }
        
    }
}
