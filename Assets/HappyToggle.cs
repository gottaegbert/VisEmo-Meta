using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class HappyToggle : MonoBehaviour
{
    double[] newResults;
    public Animator anim;
    public VisualEffect HappyParticle;
    private bool excitingUp;
    float engagementData;
    int sequence;
    float emotionData;

    private float timer = 0;
    private float delayTime = 0.25f;

    // Start is called before the first frame update
    void Update()
    {
        if(anim != null && MainScript.results != null) 
        {
            newResults = MainScript.results;
            (emotionData, sequence) = Function_BiggestEmojData.GetMax(newResults);
            if (Input.GetKeyDown(KeyCode.H) && !excitingUp)
            {
                
                anim.SetTrigger("HappyUp");

                if(HappyParticle != null)
                HappyParticle.Play();
                Debug.Log("happytoggle");

                excitingUp = true;
                StartCoroutine(ResetBool(excitingUp,0.5f));
            }

            if (timer >= delayTime)
            {

                //------------------------------------------Set color, size and environment color-----------------------------------------
                selectEmotion();
                selectSize();
            
                //Function_EnvironmentBar1.SetEnvironValue();

                timer = 0;

            }
        }
    }

    // Update is called once per frame
   IEnumerator ResetBool (bool boolToReset, float delay = 0.1f)
    {
        yield return new WaitForSeconds(delay);
        excitingUp = !excitingUp;
    }


    void selectEmotion()
    {

        switch (sequence)
        {
            case 3:
                Function_VFX_Meeting.Happiness(HappyParticle, emotionData);
                break;

            case 4:
                Function_VFX_Meeting.Surprise(HappyParticle, emotionData);
                break;


            case 6:
                Function_VFX_Meeting.Anger(HappyParticle, emotionData);
                break;

        }
    }
    void selectSize()
    {
        Function_VFX_Meeting.changeSize(HappyParticle, engagementData);
    }
}

