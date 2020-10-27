using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr_endGame : MonoBehaviour
{
    public GameObject player;
   // public GameObject gameOver;
    public string newScene;
    public scr_panelTweener panelTweener;


    private void OnTriggerEnter(Collider other)
    {
        if(other.name == player.name)
        {
            StartCoroutine(EndGameIE());
        }
    }

    IEnumerator EndGameIE()
    {
        panelTweener.TweenPanel();
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(newScene);
    }

}
