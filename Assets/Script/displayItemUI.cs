using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayItemUI : MonoBehaviour
{
    public string myString;
    private Text myText;
    public string specificObj; //if an object needs a specific action to go with it (like pick up) set the string to name of object
    private bool iBool; //bool used for different purposes.

    public Renderer regFilm;
    public Renderer redFilm;

    public GameObject helpText;
    public GameObject door;

    public scr_PlayerWalkingDialogue changeString;

    // Start is called before the first frame update
    void Start()
    {
        iBool = false;
        myText = GameObject.Find("UI").GetComponent<Text> ();
        myText.color = Color.clear;
    }
    // Update is called once per frame
    void Update()
    {

        if(globalVarStorage.hasCamera == true && globalVarStorage.hasFilm == false)
        {
            helpText.SetActive(true);
        }

        if(specificObj == "bwFilm" && iBool)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                // here is the film thing 
                changeString.playerThought = "I guess I can head to my first interview. I’ll finally find out what really came first.";
                changeString.uiText.text = changeString.playerThought;
                globalVarStorage.hasFilm = true;
                regFilm.enabled = false;
                redFilm.enabled = false;

                helpText.SetActive(false);
                door.SetActive(false);

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(specificObj == "bwFilm")
        {
            if (globalVarStorage.hasCamera)
            {
               // myText.text = myString;
              //  myText.color = Color.white;
                iBool = true;
            }
        }
        else
        {
            myText.text = myString;
            myText.color = Color.white;
            iBool = false;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        myText.color = Color.clear;
        iBool = false;
    }
}
