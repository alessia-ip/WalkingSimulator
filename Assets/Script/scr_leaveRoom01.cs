using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_leaveRoom01 : MonoBehaviour
{
    //public GameObject door;
    public MeshCollider doorCollider;
    bool test;
    // Start is called before the first frame update
    void Start()
    {
        doorCollider = GetComponent<MeshCollider>();
        test = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (globalVarStorage.hasFilm)
        {
            doorCollider.enabled = false;
        }
    }
}
