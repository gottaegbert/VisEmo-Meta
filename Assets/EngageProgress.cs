using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Michsky.UI.ModernUIPack;
using UnityEngine.UI;


public class EngageProgress : MonoBehaviour
{

    double[] newResults;
    float engagementData;
    private float timer = 0;
    private float delayTime = 0.1f;


    public ProgressBar myBar;
    public GameObject LoadingBar;
    private Image image;

    // Start is called before the first frame update
    void Start()
    {
        image = LoadingBar.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MainScript.results != null)
        {
            newResults = MainScript.results;
            engagementData = Function_DoubletoFloat.emoMath(newResults[9])/100f;



            //----------------Set delay------------------
            timer += Time.deltaTime;

            if (timer >= delayTime)
            {
                myBar.ChangeValue(engagementData);
                //Debug.Log(engagementData);


                if (engagementData < 30.0f)
                {
                    image.color = new Color(0, 0.7f, 1);
                }

                else
                {
                    image.color = new Color(1, 0.7f, 0);
                }

                timer = 0;

            }




        }
    }
}
