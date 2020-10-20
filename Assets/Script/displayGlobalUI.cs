using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayGlobalUI : MonoBehaviour
{
    private Text uiText;
    private string uiString;
    public static string uiNum = "nothing"; //this is for if we want different timed UIs
    // Start is called before the first frame update
    void Start()
    {

        uiText = GameObject.Find("UI").GetComponent<Text>(); //set uiText to be the ui text component
        uiText.color = Color.clear; //set uiText to clear
    }

    // Update is called once per frame
    void Update()
    {
        if (uiNum == "zoomHowTo")
        {
            //once character picks up camera uniNum is set to zoomHowTo. This activates the rbs ui info
            uiString = "Use *rbs* to zoom";
            uiText.text = uiString;
            uiText.color = Color.white;
            StartCoroutine(UiHide());

        }
    }

    //UiHide will hide the rbs ui after 3 seconds. also set uiNum to nothing;
    IEnumerator UiHide()
    {
        yield return new WaitForSeconds(3);
        uiNum = "nothing";
        uiText.color = Color.clear;

    }
}
