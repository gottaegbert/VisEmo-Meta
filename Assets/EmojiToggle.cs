using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class EmojiToggle : MonoBehaviour
{
    double[] newResults;
    public Animator anim;
    public VisualEffect HappyParticle;
    private VisualEffect Happyelement;

    public VisualEffect AngryParticle;
    private VisualEffect AngryElement;


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
        if (anim != null && MainScript.results != null)
        {
            if (sequence == 3)
            {

                anim.SetBool("HappyUp", true);
                Debug.Log("happytoggle");

                if (HappyParticle != null || timer >= _delayTimeAnmition)
                {
                    HappyParticle.Play();
                    
                    timer = 0;
                    Debug.Log("happyanimation");
                    //StartCoroutine(ResetBool(excitingUp,0.5f));
                }
               
               
            }
            //&& !excitingUp
            else
            {
                anim.SetBool("HappyUp", false);
               // excitingUp = true;
            }

            if (sequence == 6)
            {

                //anim.SetTrigger("Angryup");

                if (AngryParticle != null)
                    AngryParticle.Play();
                Debug.Log("angrytoggle");
            }

            if (timer >= delayTime)
            {
                selectSize();
                timer = 0;
            }
        }
    }

   IEnumerator ResetBool (bool boolToReset, float delay = 0.1f)
    {
        yield return new WaitForSeconds(delay);
        excitingUp = !excitingUp;
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

