
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Michsky.UI.ModernUIPack;
using UnityEngine.UI;

public class MaxemoProgress : MonoBehaviour
{

    double[] newResults;
    float emotionData;

    private Vector4 col;


    int sequence;
    private float timer = 0;
    private float delayTime = 1f;

    //public ProgressBar myBar;

    public Image image;
    private float transparency=1;


    // Start is called before the first frame update
    void Start()
    {
         //col = myBar.GetComponent<Color>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MainScript.results != null)
        {
            newResults = MainScript.results;

            //Set bar color
            //Set image element color

            (emotionData, sequence) = Function_BiggestEmojData.GetMax(newResults);
            selectEmotion();

            image.color = col;
            
            
            //col = color[sequence];

            //myBar.ChangeValue(emotionData);




        }
    }

    void selectEmotion()
    {
        

        switch (sequence)
        {
            case 3:
                col= new Vector4(0, emotionData / 100, emotionData / 200, transparency);
                break;

            case 4:
                col = new Vector4(emotionData / 100, emotionData / 100, 0, transparency);
                break;

            case 5:
                col = new Vector4(0,emotionData / 200, emotionData / 100, transparency);
                break;

            case 6:
                col = new Vector4(emotionData / 100, 0, 0, transparency);
                break;

            case 7:
                col = new Vector4(emotionData / 200, emotionData / 200, 0, transparency);
                break;

            case 8:
                col = new Vector4(emotionData / 100, emotionData / 200, 0, transparency);
                break;

        }
    }

}
