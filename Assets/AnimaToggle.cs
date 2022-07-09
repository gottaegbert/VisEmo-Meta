using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class AnimaToggle : MonoBehaviour
{
    double[] newResults;
    public Animator anim;
   
    private bool excitingUp;
  
    int sequence;
    float emotionData;

    private float timer = 0;
   
    private float _delayTimeAnmition = 1.0f;

    
    void Start()
    {
       
    }
    void Update()
    {
        newResults = MainScript.results;

        (emotionData, sequence) = Function_BiggestEmojData.GetMax(newResults);
        if (anim != null && MainScript.results != null)
        {
            if (sequence == 3 || timer >= _delayTimeAnmition)
            {
                anim.SetBool("HappyUp", true);
                timer = 0;
                Debug.Log("happyanimation");
               StartCoroutine(ResetBool(excitingUp,0.5f));
                }
            else
            {
                anim.SetBool("HappyUp", false);
            }
        }

        if (anim != null && MainScript.results != null)
        {
            if (sequence == 5 || timer >= _delayTimeAnmition)
            {
                anim.SetBool("SadUp", true);
                timer = 0;
                Debug.Log("Sadanimation");
                StartCoroutine(ResetBool(excitingUp, 0.5f));
            }
            else
            {
                anim.SetBool("SadUp", false);
            }
        }
    }

   IEnumerator ResetBool (bool boolToReset, float delay = 0.1f)
    {
        yield return new WaitForSeconds(delay);
        excitingUp = !excitingUp;
    }

}

