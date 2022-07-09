using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class EmojiToggle : MonoBehaviour
{
    double[] newResults;
   
    public VisualEffect HappyParticle;
    private VisualEffect Happyelement;

    public VisualEffect AngryParticle;
    private VisualEffect AngryElement;

    public VisualEffect SadParticle;
    private VisualEffect SadElement;

    private bool excitingUp;
    float engagementData;
    int sequence;
    float emotionData;

    private float timer = 0;
    private float delayTime = 0.25f;
    private float _delayTimeAnmition = 6.1f;

    
    void Start()
    {
        Happyelement = HappyParticle.GetComponent<VisualEffect>();
    }
    void Update()
    {
        newResults = MainScript.results;
        engagementData = Function_DoubletoFloat.emoMath(newResults[9]);
        (emotionData, sequence) = Function_BiggestEmojData.GetMax(newResults);
        if ( MainScript.results != null)
        {
            if (sequence == 3)
            {

               
                Debug.Log("happytoggle");

                if (HappyParticle != null)
                {
                    HappyParticle.Play();
                      
                    Debug.Log("happyanimation");
                    //StartCoroutine(ResetBool(excitingUp,0.5f));
                }
            }
            //&& !excitingUp
            
            if (sequence == 6)
            {
                if (AngryParticle != null)
                    AngryParticle.Play();
                Debug.Log("angrytoggle");
            }
            if (sequence == 5)
            {
                if (SadParticle != null)
                    SadParticle.Play();
                Debug.Log("Sadtoggle");
            }

            if (timer >= delayTime)
            {
                selectSize();
                timer = 0;
            }
        }
    }


    void selectSize()
    {
        changeSize(HappyParticle, engagementData);
    }


    public static void changeSize(VisualEffect visualEffect, float engagementData)
    {
        visualEffect.SetFloat("Size", engagementData / 100000);
    }











}

