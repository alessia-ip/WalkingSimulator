using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class globalVarStorage : MonoBehaviour
{

    public static bool hasCamera;
    public static bool hasFilm;

    // Start is called before the first frame update
    void Start()
    {
        hasCamera = false; //test to see if player has camera
        hasFilm = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
