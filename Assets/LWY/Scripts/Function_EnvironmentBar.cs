using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Michsky.UI;

public class Function_EnvironmentBar : MonoBehaviour
{
    
    public Slider sd;
    public Gradient gradient;
    public Image fill;



    void Start()
    {
        sd = GetComponent<Slider>();
        
    }

    void Update()
    {
        fill.tintColor = gradient.Evaluate((sd.value / 100));
    }




    /*
    public void SetEngagement(int engagement)
    {
        slider.value = engagement;

        fill.tintColor = gradient.Evaluate(slider.SliderNormalizeValue(slider.value,0,100));

    }

    */



}
