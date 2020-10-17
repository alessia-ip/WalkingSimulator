using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalVarStorage : MonoBehaviour
{

    public static bool hasCamera;
    // Start is called before the first frame update
    void Start()
    {
        hasCamera = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hasCamera);
    }
}
