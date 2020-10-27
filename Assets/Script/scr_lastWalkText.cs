using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_lastWalkText : MonoBehaviour
{

    public GameObject blockHouse;
    public GameObject blockHouse2;

    public GameObject walkingText;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(blockHouse.activeInHierarchy);
        if(blockHouse.activeInHierarchy == false && blockHouse2.activeInHierarchy == false)
        {
            walkingText.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
