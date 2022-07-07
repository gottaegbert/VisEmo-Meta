using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Function_EnvironmentBar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;



    void Start()
    {
        slider = GetComponent<Slider>();
        
    }

    void Update()
    {
        fill.tintColor = gradient.Evaluate((slider.value / 100));
    }




    /*
    public void SetEngagement(int engagement)
    {
        slider.value = engagement;

        fill.tintColor = gradient.Evaluate(slider.SliderNormalizeValue(slider.value,0,100));

    }

    */



}
