using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using System;

//1.Prevalent Emotion
//2.Neutral

//Use the biggest data to set color saturation   6 EMOTIONS
//3.Happiness  Green(0,1,0.5)
//4.Surprise   Yellow(1,1,0)
//5.Sadness    Blue(0,0.5,1)
//6.Anger      Red(1,0,0)
//7.Disgust    Purple(128,0,128)
//8.Fear       Orange(1,0.5,0)

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

        visualEffect.SetVector4("Color", new Vector4(0, emotionData / 100, emotionData / 200));


        //visualEffect.SetFloat("_Intensity",0f);
        //_Intensity ("Intensity",Float) = 0

        Debug.Log("Happiness" + emotionData);

    }


    public static void Surprise(VisualEffect visualEffect, float emotionData)
    {
        //float intensity=ChangeEffect.intensity;


        //Set to adjust intensity
        float factor = Mathf.Pow(2, 5.0f);


        visualEffect.SetVector4("Color", new Vector4(emotionData / 100, emotionData / 100 , 0));


        //visualEffect.SetFloat("_Intensity",0f);
        //_Intensity ("Intensity",Float) = 0


        Debug.Log("Surprise" + emotionData);

    }

    public static void Sadness(VisualEffect visualEffect, float emotionData)
    {
        //float intensity=ChangeEffect.intensity;

        float factor = Mathf.Pow(2, 5.0f);


        visualEffect.SetVector4("Color", new Vector4(0,emotionData / 200 ,emotionData / 100 ));

        //visualEffect.SetFloat("_Intensity",0f);
        //_Intensity ("Intensity",Float) = 0

        Debug.Log("Sadness:" + emotionData);
    }

 


    public static void Anger(VisualEffect visualEffect, float emotionData)
    {
        //float intensity=ChangeEffect.intensity;

        float factor = Mathf.Pow(2, 5.0f);


        visualEffect.SetVector4("Color", new Vector4(emotionData / 100, 0, 0));

        //visualEffect.SetFloat("_Intensity",0f);
        //_Intensity ("Intensity",Float) = 0

        Debug.Log("Anger:" + emotionData);
    }

    public static void Disgust(VisualEffect visualEffect, float emotionData)
    {
        //float intensity=ChangeEffect.intensity;

        float factor = Mathf.Pow(2, 5.0f);


        visualEffect.SetVector4("Color", new Vector4(emotionData / 200, 0, emotionData / 200));

        //visualEffect.SetFloat("_Intensity",0f);
        //_Intensity ("Intensity",Float) = 0

        Debug.Log("Disgust:" + emotionData);
    }

    public static void Fear(VisualEffect visualEffect, float emotionData)
    {
        //float intensity=ChangeEffect.intensity;

        float factor = Mathf.Pow(2, 5.0f);


        visualEffect.SetVector4("Color", new Vector4(emotionData / 100, emotionData / 200,0));

        //visualEffect.SetFloat("_Intensity",0f);
        //_Intensity ("Intensity",Float) = 0

        Debug.Log("Fear:" + emotionData);
    }





    public static void changeSize(VisualEffect visualEffect, float engagementData)
    {
        visualEffect.SetFloat("Size",engagementData/100*5);
    }




    public static void changeEnvironment(Material material, float engagementData)
    {
        if (engagementData<50.0f)
        {
            material.SetColor("_EmissionColor", new Color(0, 0.5f* (100 - engagementData)/100f, 1.0f* (100 - engagementData) / 100f));

        }
        else
        {
            material.SetColor("_EmissionColor", new Color(1.0f * (100 - engagementData) / 100f, 0.5f * (100 - engagementData) / 100f, 0));

        }
    }

}
