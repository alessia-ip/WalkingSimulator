using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayAllUI : MonoBehaviour
{
    public string myString;
    private Text myText;

    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("UI").GetComponent<Text> ();
        myText.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        myText.text = myString;
        myText.color = Color.white;
    }

    private void OnTriggerExit(Collider other)
    {
        myText.color = Color.clear;
    }
}
