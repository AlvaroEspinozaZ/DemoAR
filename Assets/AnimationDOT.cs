using UnityEngine;
using System.Collections.Generic;
using System.Threading.Tasks;
using DG.Tweening;
using System;
public class AnimationDOT : MonoBehaviour
{
    public float timetoWait;
    public float duracionAnimacion;
    public Vector3 inScreem;
    private Vector3 scaleInit;
    private void Awake()
    {
        scaleInit = transform.localScale;
        transform.localScale = Vector3.zero;
    }
    void Start()
    {
    }

    private void OnEnable()
    {
        AniButtonMoveInScreem();
    }
    private async void AniButtonMoveInScreem()
    {
        //transform.localScale = Vector3.zero;
        //await transform.DOScale(Vector3.zero, 0.01f).SetEase(Ease.InOutSine).AsyncWaitForCompletion();
        List<Task> currentTask = new List<Task>();
        currentTask.Add(transform.DOScale(scaleInit, duracionAnimacion).SetEase(Ease.InOutSine).AsyncWaitForCompletion());
        currentTask.Add(transform.DOMove(inScreem, duracionAnimacion).SetEase(Ease.InOutCubic).AsyncWaitForCompletion());
        await Task.WhenAll(currentTask);
    }
    private void OnDisable()
    {
        transform.localScale = Vector3.zero;
    }
}
