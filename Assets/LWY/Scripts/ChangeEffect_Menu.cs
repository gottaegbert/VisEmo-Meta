using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.VFX;


public class ChangeEffect_Menu : MonoBehaviour
{
    
    //Receive MainScript
    double[] newResults;
    

    //Receive biggest emotionData
    float emotionData;
    float engagementData;
    int sequence;


    //Set environmemt material
    //public Material material;


    //Set Objects
    public GameObject ColorElement;
    public Image image;
    

    //Set time delay, not detect so fast
    private float timer = 0;
    private float delayTime = 0.25f;



    void Start()
    {
        //visualEffect=VFXElement.GetComponent<VisualEffect>();
        image=ColorElement.GetComponent<Image>();
    }



    void Update()
    {

        if(MainScript.results!=null)
        {
            newResults = MainScript.results;
            (emotionData,sequence)=Function_BiggestEmojData.GetMax(newResults);
            engagementData = Function_DoubletoFloat.emoMath(newResults[9]);
            //Debug.Log(engagementData);

            //Set delay--------
            timer+= Time.deltaTime;

            if(timer>=delayTime)
            {

                //------------------------------------------Set color, size-----------------------------------------
                selectEmotion();
                //image.color = Color.red;

                timer =0;

            }

        }

    }


    void selectEmotion(){
             /*       
            switch (sequence)
            {
                case 3:
                    Function_VFX_Meeting.Happiness(visualEffect,emotionData);
                    break;

                case 4:
                    Function_VFX_Meeting.Surprise(visualEffect,emotionData);
                    break;

            case 5:
                Function_VFX_Meeting.Sadness(visualEffect, emotionData);
                break;


            case 6:
                    Function_VFX_Meeting.Anger(visualEffect,emotionData);
                    break;

            case 7:
                Function_VFX_Meeting.Disgust(visualEffect, emotionData);
                break;

            case 8:
                Function_VFX_Meeting.Fear(visualEffect, emotionData);
                break;

        }

        */
    }





    }




