using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Michsky.UI.ModernUIPack;

public class HealthBar : MonoBehaviour
{
    public SliderManager slidermanager;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(slidermanager.mainSlider.value);


    }
}