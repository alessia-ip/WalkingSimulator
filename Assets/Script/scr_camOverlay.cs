using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class scr_camOverlay : MonoBehaviour
{

    public GameObject camImage;
    public PostProcessVolume volume;


    private void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            camImage.SetActive(true);
            ChromaticAberration chromaticAberration;
            if (volume.profile.TryGetSettings(out chromaticAberration))
            {
                chromaticAberration.intensity.value = 1;
            }

        } else
        {
            camImage.SetActive(false);
            ChromaticAberration chromaticAberration;
            if (volume.profile.TryGetSettings(out chromaticAberration))
            {
                chromaticAberration.intensity.value = 0;
            }
        }
    }
}
