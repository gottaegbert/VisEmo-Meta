using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.VFX;


public class ChangeEffect : MonoBehaviour
{
    
    //Receive MainScript
    double[] newResults;
    

    //Receive biggest emotionData
    float emotionData;
    float engagementData;
    int sequence;


    //Set environmemt material
    public Material material;


    //Set Objects
    public GameObject VFXElement;
    private VisualEffect visualEffect;
    

    //Set time delay, not detect so fast
    private float timer = 0;
    private float delayTime = 0.25f;



    void Start()
    {
        visualEffect=VFXElement.GetComponent<VisualEffect>();

    }



    void Update()
    {

        if(MainScript.results!=null)
        {
            newResults = MainScript.results;
            (emotionData,sequence)=Function_BiggestEmojData.GetMax(newResults);
            engagementData = Function_DoubletoFloat.emoMath(newResults[9]);
            Debug.Log(engagementData);

            //Set delay--------
            timer+= Time.deltaTime;

            if(timer>=delayTime)
            {

                //------------------------------------------Set color, size and environment color-----------------------------------------
                selectEmotion();
                selectSize();
                selectEnvironmetColor();

                timer =0;

            }

        }

    }


    void selectEmotion(){
                    
            switch (sequence)
            {
                case 3:
                    Function_VFX_Meeting.Happiness(visualEffect,emotionData);
                    break;

                case 4:
                    Function_VFX_Meeting.Surprise(visualEffect,emotionData);
                    break;


                case 6:
                    Function_VFX_Meeting.Anger(visualEffect,emotionData);
                    break;

            }
    }

    void selectSize()
    {
        Function_VFX_Meeting.changeSize(visualEffect, engagementData);
    }

    void selectEnvironmetColor()
    {
        Function_VFX_Meeting.changeEnvironment(material);
    }





    }




