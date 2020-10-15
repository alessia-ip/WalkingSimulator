using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_script : MonoBehaviour
{

    public GameObject[] crow;
    public int numberthing;
    public Outline outlineScr;

    bool isPlayed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(isPlayed == false)
        {
            isPlayed = true;

        }
    }


}
