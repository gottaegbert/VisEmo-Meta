using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisualizerScript : MonoBehaviour
{
    double[] newResults;
    float[] emotionData;

    public float minHeight = 15.0f;
    public float maxHeight = 275.0f;
    public float updateSentivity = 10.0f;
    public Color visualizerColor = Color.gray;
    [Space(15)]

    public bool loop = true;
    [Space(15), Range(0, 100)]
    public int visualizerSimples = 64;

    public RectTransform[] visualizerObjects;
    // Start is called before the first frame update
    void Start()
    {
        visualizerObjects = GetComponentsInChildren<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
       
    
        newResults = MainScript.results;

        for (int i = 0; i < visualizerObjects.Length; i++)
        {
            //Debug.Log("PIECHART" + emotionData[1]);
            //emotionData[i] = Function_DoubletoFloat.emoMath(newResults[i]);
            Vector2 newSize = visualizerObjects[i].GetComponent<RectTransform>().rect.size;
           newSize.y = Mathf.Clamp(Mathf.Lerp(newSize.y, minHeight + (Function_DoubletoFloat.emoMath(newResults[i]) * (maxHeight - minHeight) * 0.5f), updateSentivity * 0.05f), minHeight, maxHeight);
            //newSize.y = 2.0f*Function_DoubletoFloat.emoMath(newResults[i]);
            visualizerObjects[i].GetComponent<RectTransform>().sizeDelta = newSize;

            //visualizerObjects[i].GetComponent<Image>().color = visualizerColor;
        }

       
    }
}
