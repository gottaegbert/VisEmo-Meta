
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Michsky.UI.ModernUIPack;


public class MaxemoProgress : MonoBehaviour
{

    double[] newResults;
    float emotionData;
    private Vector4 col;
    int sequence;
    private float timer = 0;
    private float delayTime = 1f;
    public ProgressBar myBar;
    // Start is called before the first frame update
    void Start()
    {
         col = myBar.GetComponent<Color>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MainScript.results != null)
        {
            newResults = MainScript.results;
            (emotionData, sequence) = Function_BiggestEmojData.GetMax(newResults);
            myBar.ChangeValue(emotionData);
            //col = color[sequence];
        }
    }

    void selectEmotion()
    {

        switch (sequence)
        {
            case 3:
                col= new Vector4(0, emotionData / 100, emotionData / 200);
                break;

            case 4:
                col = new Vector4(emotionData / 100, emotionData / 100, 0);
                break;

           

        }
    }

}
