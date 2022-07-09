//pie chart emoj
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Michsky.UI.ModernUIPack;

public class PieEmoj : MonoBehaviour
{
    double[] newResults;
    public UIManagerPieChart data;
    public float minHeight = 15.0f;
    public float maxHeight = 275.0f;
    public float updateSentivity = 10.0f;
    public Color visualizerColor = Color.gray;
    
    [Space(15)]

    public bool loop = true;

    //Set time delay, not detect so fast
    private float timer = 0;
    private float delayTime = 1f;
    public PieChart myChart;
    private UIManagerPieChart x;
    

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
            myChart.chartData[1].value = Function_DoubletoFloat.emoMath(newResults[3]);

            //Set delay-------
                AddPie();

        }

    
    }



    void AddPie()
    {
        
        for (int i = 0; i < 6; i++)
        {

          
                //float _newvalue = myChart.chartData[i].value;
                //_newvalue = newResults
                //_newvalue = Mathf.Clamp(Mathf.Lerp(_newvalue, minHeight + (Function_DoubletoFloat.emoMath(newResults[i+2]) * (maxHeight - minHeight) * 0.5f), updateSentivity * 0.05f), minHeight, maxHeight);
              //  Debug.Log(newResults[i + 2]);
            myChart.ChangeValue(i, Function_DoubletoFloat.emoMath(newResults[i + 2]));
            myChart.UpdateIndicators();
           
        }
    }
}