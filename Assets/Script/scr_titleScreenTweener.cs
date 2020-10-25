using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class scr_titleScreenTweener : MonoBehaviour
{
    private void Start()
    {
        transform.localScale = new Vector2(0, transform.localScale.y);
    }

    public void TweenOpen()
    {
        transform.DOScaleX(0.96f, 1f).SetEase(Ease.OutExpo);
    }

    public void TweenShut()
    {
        transform.DOScaleX(0f, 0.2f).SetEase(Ease.OutExpo);
    }

}
