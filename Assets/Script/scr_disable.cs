using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_disable : MonoBehaviour
{
    public GameObject[] toBeTurnedOff;
    public GameObject[] toBeTurnedOn;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            for(int i = 0; i < toBeTurnedOff.Length; i++)
            {
                toBeTurnedOff[i].SetActive(false);
            }
            for (int i = 0; i < toBeTurnedOn.Length; i++)
            {
                toBeTurnedOn[i].SetActive(true);
            }
        }
    }
}
