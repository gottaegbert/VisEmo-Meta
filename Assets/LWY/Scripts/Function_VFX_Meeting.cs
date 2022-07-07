using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using System;

//1.Prevalent Emotion
//2.Neutral

//Use the biggest data to set color saturation
//3.Happiness  Yellow(255,255,0)
//4.Surprise   Orange(255,128,0)
//5.Sadness    Blue(0,0,255)
//6.Anger      Red(255,0,0)
//7.Disgust    Purple(128,0,128)
//8.Fear       Green(0,255,0)

//Size of the VFX          
//9.Engagement       


//10.Valence



public class Function_VFX_Meeting : MonoBehaviour
{

    public static void Happiness(VisualEffect visualEffect, float emotionData)
    {
        //float intensity=ChangeEffect.intensity;


        //Set to adjust intensity
        float factor = Mathf.Pow(2, 5.0f);


        visualEffect.SetVector4("Color", new Vector4(emotionData / 100 * 255 / factor, emotionData / 100 * 255 / factor, 30 / factor, 0));


        //visualEffect.SetFloat("_Intensity",0f);
        //_Intensity ("Intensity",Float) = 0

        Debug.Log("Anger:" + emotionData);

    }


    public static void Surprise(VisualEffect visualEffect, float emotionData)
    {
        //float intensity=ChangeEffect.intensity;


        //Set to adjust intensity
        float factor = Mathf.Pow(2, 5.0f);


        visualEffect.SetVector4("Color", new Vector4(emotionData / 100 * 255 / factor, emotionData / 100 * 128 / factor, 30 / factor, 0));


        //visualEffect.SetFloat("_Intensity",0f);
        //_Intensity ("Intensity",Float) = 0


        Debug.Log("Anger:" + emotionData);

    }


    public static void Anger(VisualEffect visualEffect, float emotionData)
    {
        //float intensity=ChangeEffect.intensity;

        float factor = Mathf.Pow(2, 5.0f);


        visualEffect.SetVector4("Color", new Vector4(emotionData / 100 * 255 / factor, 30 / factor, 30 / factor, 0));

        //visualEffect.SetFloat("_Intensity",0f);
        //_Intensity ("Intensity",Float) = 0

        Debug.Log("Anger:" + emotionData);
    }

    public static void changeSize(VisualEffect visualEffect, float engagementData)
    {
        visualEffect.SetFloat("Size",engagementData/10000*5);
    }

    public static void changeEnvironment(Material material)
    {
        
        material.SetColor("_EmissionColor", new Color(UnityEngine.Random.Range(0f, 1f), 0.5f, 1-UnityEngine.Random.Range(0f, 1f)));
    }

}
