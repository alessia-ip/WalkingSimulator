using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class globalVarStorage : MonoBehaviour
{

    public static bool hasCamera;
    public Text uiText;
    public string uiString;
    public float fadeTime;
    public static int uiNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        hasCamera = false; //test to see if player has camera
        uiText = GameObject.Find("UI").GetComponent<Text>(); //set uiText to be the ui text component
        uiText.color = Color.clear; //set uiText to clear
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(hasCamera);
        if (uiNum == 1)
        {
            uiString = "Use *rbs* to zoom";
            uiText.text = uiString;
            uiText.color = Color.white;
            //uiText.color = Color.Lerp(uiText.color, Color.white, fadeTime * Time.deltaTime);
            StartCoroutine(UiHide());

        }

    }

    IEnumerator UiHide()
    {
        yield return new WaitForSeconds(3);
        uiNum++;
        uiText.color = Color.Lerp(uiText.color, Color.clear, fadeTime * Time.deltaTime);
    }
}
