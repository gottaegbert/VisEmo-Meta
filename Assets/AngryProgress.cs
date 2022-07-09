using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Michsky.UI.ModernUIPack;


public class AngryProgress : MonoBehaviour
{

    double[] newResults;
    float engagementData;
    private float timer = 0;
    private float delayTime = 1f;
    public ProgressBar myBar;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MainScript.results != null)
        {
            newResults = MainScript.results;
            engagementData = Function_DoubletoFloat.emoMath(newResults[6]);
            //Debug.Log(engagementData);
            myBar.ChangeValue(engagementData);
        }
    }
}
