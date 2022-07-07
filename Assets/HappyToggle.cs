using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class HappyToggle : MonoBehaviour
{
    public Animator anim;
    public VisualEffect HappyParticle;
    private bool excitingUp;
    
       // Start is called before the first frame update
    void Update()
    {
        if(anim != null) 
        {
            if(Input.GetKeyDown(KeyCode.H) && !excitingUp)
            {
                
                anim.SetTrigger("HappyUp");

                if(HappyParticle != null)
                HappyParticle.Play();

                excitingUp = true;
                StartCoroutine (ResetBool(excitingUp,0.5f));
            }
        }
    }

    // Update is called once per frame
   IEnumerator ResetBool (bool boolToReset, float delay = 0.1f)
    {
        yield return new WaitForSeconds(delay);
        excitingUp = !excitingUp;
    }
}
