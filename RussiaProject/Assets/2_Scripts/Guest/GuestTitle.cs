using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestTitle : MonoBehaviour
{ 
    public RectTransform rectLoading;
    public GameObject test;

    private float timeLading;
    private const float UPDATE_CYCLE = 0.2f;
    private void Start()
    {
        rectLoading = GameObject.Find("Img_Loading").GetComponent<RectTransform>();

        timeLading = UPDATE_CYCLE;

    }

    private void Update()
    {
        UpdateLoading();
        //rectLoading.Rotate(0,0, - (100f * Time.deltaTime));
    }



    public void UpdateLoading()
    {
        timeLading -= Time.deltaTime;
        if (timeLading < 0)
        {
            rectLoading.Rotate(0, 0, -10f);
            timeLading = UPDATE_CYCLE;
        }
    }
}
