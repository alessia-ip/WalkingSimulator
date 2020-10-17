using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayUI : MonoBehaviour
{

    public string myString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;
    public KeyCode pickUp;
    public GameObject interactObj;

    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("Text").GetComponent<Text> ();
        myText.color = Color.clear;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(pickUp) && displayInfo)
        {
            ItemPickUp();
        }
        
        FadeText();
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("pressed button");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        displayInfo = true;
        Debug.Log("in circle");
    }

    private void OnTriggerExit(Collider other)
    {
        displayInfo = false;
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
            myText.color = Color.Lerp(myText.color, Color.white, fadeTime * Time.deltaTime);
        }
        else
        {
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }

    void ItemPickUp()
    {
        globalVarStorage.hasCamera = true;
        displayInfo = false;
        myText.color = Color.clear;
        if(myText.color == Color.clear)
        {
            interactObj.SetActive(false);
        }
        
    }
}
