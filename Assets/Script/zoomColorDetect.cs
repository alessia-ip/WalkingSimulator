using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomColorDetect : MonoBehaviour
{
    public GameObject[] redObjects;
    public GameObject[] bwObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //when zoomed switch important objects to red
    public void ZoomSwitchRed()
    {
        //Debug.Log("hello world");

        for (int i = 0; i < redObjects.Length; i++)
        {
            redObjects[i].SetActive(true);
        }
        for (int i = 0; i < redObjects.Length; i++)
        {
            bwObjects[i].SetActive(false);
        }

    }

    //when not zoomed keep items black and white
    public void ZoomSwitchBW()
    {
        for (int i = 0; i < redObjects.Length; i++)
        {
            redObjects[i].SetActive(false);
        }
        for (int i = 0; i < redObjects.Length; i++)
        {
            bwObjects[i].SetActive(true);
        }
    }
}

