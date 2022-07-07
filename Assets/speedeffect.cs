using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class speedeffect : MonoBehaviour
{
    double[] newResults;
    
    //Receive biggest emotionData
    float emotionData;

    public GameObject Sphere;
    public Material Shader_2_1;
    void Start()
    {
        
    }

    void Update()
    {
        // newResults = script.results;
        newResults = MainScript.results;
       
        emotionData=Function_DoubletoFloat.emoMath(newResults[6]);
        Debug.Log("anger!" + emotionData);

        if(Shader_2_1 != null){
            // time speed 
           
            Shader_2_1.SetFloat("_TimeSpeed",emotionData);
            // timeSpeedSliderLabel.text = $"Time Speed: {timeSpeedSlider.value}";
            // Shader_2_1.SetColor
            // noise scale
            // Shader_2_1.SetFloat("_NoiseScale", noiseScaleSlider.value);
            // noiseScaleSliderLabel.text = $"Noise Scale: {noiseScaleSlider.value}";
        }        
      

    }
}
