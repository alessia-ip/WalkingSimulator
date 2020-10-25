using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr_titleScreen : MonoBehaviour
{

    public scr_titleScreenTweener titleScreenTweener;
    public scr_panelTweener panelTweener;
    public string newScene;

    public void TweenOpen()
    {
        titleScreenTweener.TweenOpen();
    }

    public void TweenClosed()
    {
        titleScreenTweener.TweenShut();
    }

    public void NextScene()
    {

        StartCoroutine(sceneStart());
    }

    public IEnumerator sceneStart()
    {
        panelTweener.TweenPanel();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(newScene);
    }

}
