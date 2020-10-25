using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class scr_panelTweener : MonoBehaviour
{

    public void TweenPanel()
    {
        transform.DOMoveY(0f, 2f).SetEase(Ease.OutExpo);
    }

}
