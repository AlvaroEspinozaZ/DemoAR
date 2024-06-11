using UnityEngine;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DG.Tweening;

public class ControllerG : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    void Start()
    {
        ActivarObj();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private async void ActivarObj()
    {
        obj1.SetActive(false);
        obj2.SetActive(false);
        await Task.Delay(TimeSpan.FromSeconds(0.1f));
        obj1.SetActive(true);
        obj2.SetActive(true);
    }
}
