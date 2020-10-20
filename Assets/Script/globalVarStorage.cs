using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class globalVarStorage : MonoBehaviour
{

    public static bool hasCamera;
    public Text uiInput;
    public string uiText;
    public float fadeTime;
    public static int uiNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        hasCamera = false; //test to see if player has camera
        uiInput = GameObject.Find("UI").GetComponent<Text>(); //set uiInput to be the ui text component
        uiInput.color = Color.clear; //set uiInput to clear
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(hasCamera);
        if (uiNum == 1)
        {
            uiText = "Use *rbs* to zoom";
            uiInput.text = uiText;
            uiInput.color = Color.white;
            //uiInput.color = Color.Lerp(uiInput.color, Color.white, fadeTime * Time.deltaTime);
            StartCoroutine(UiHide());

        }

    }

    IEnumerator UiHide()
    {
        yield return new WaitForSeconds(3);
        uiNum++;
        uiInput.color = Color.Lerp(uiInput.color, Color.clear, fadeTime * Time.deltaTime);
    }
}
