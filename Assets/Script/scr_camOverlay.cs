using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class scr_camOverlay : MonoBehaviour
{

    public GameObject camImage;
    public PostProcessVolume volume;

    public AudioSource aud;
    public AudioClip snap;

    bool activated = false;


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
            if(activated == false)
            {
                aud.PlayOneShot(snap);
                activated = true;
            }

        } else
        {
            camImage.SetActive(false);
            ChromaticAberration chromaticAberration;
            if (volume.profile.TryGetSettings(out chromaticAberration))
            {
                chromaticAberration.intensity.value = 0;
            }
            activated = false;
        }
    }
}
