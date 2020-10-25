using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class scr_ItemTweener : MonoBehaviour
{
    void Start()
    {
        transform.localScale = new Vector2(transform.localScale.x, 0);
    }

    private void Update()
    {
        //this is just to test the tween
        /*if (Input.GetKeyDown(KeyCode.Y))
        {
            TweenOpen();
        }*/
        //this is just to test the tween
        /*if (Input.GetKeyDown(KeyCode.U))
        {
            TweenShut();
        }*/
    }

    public void TweenOpen()
    {
        transform.DOScaleY(1f, 1f).SetEase(Ease.OutExpo);
    }

    public void TweenShut()
    {
        transform.DOScaleY(0f, 0.2f).SetEase(Ease.OutExpo);
    }
}
