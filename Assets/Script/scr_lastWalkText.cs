using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_lastWalkText : MonoBehaviour
{

    public GameObject blockHouse;
    public GameObject blockHouse2;

    public GameObject walkingText;



    // Update is called once per frame
    void Update()
    {
        Debug.Log(blockHouse.activeSelf);
        if (blockHouse.activeSelf == false && blockHouse2.activeSelf == false)
        {
            walkingText.SetActive(true);
        }
    }
}
