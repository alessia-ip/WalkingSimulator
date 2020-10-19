using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_camScreenshot : MonoBehaviour
{

    public Camera zoomIn;
    int i = 0;
    bool captured = false;

    // Update is called once per frame
    void Update()
    {

        if( zoomIn.GetComponent<Camera>().fieldOfView <= 40.1 && captured == false)
        {
            Debug.Log("screenshot");
            ScreenCapture.CaptureScreenshot("Screenshots/" + i + "TestingShot.png");
            i++;

            //preventing multiple screenshots
            captured = true;
        }

        if(zoomIn.GetComponent<Camera>().fieldOfView > 40.1)
        {
            captured = false;
        }
    }
}
