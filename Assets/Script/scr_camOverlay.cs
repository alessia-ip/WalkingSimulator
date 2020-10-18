using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_camOverlay : MonoBehaviour
{

    public GameObject camImage;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            camImage.SetActive(true);
        } else
        {
            camImage.SetActive(false);
        }
    }
}
