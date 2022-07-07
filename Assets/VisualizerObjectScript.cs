using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizerObjectScript : MonoBehaviour
{
    //public GameObject PieChart;
   
    public VisualizerObjectScript[] VisualizerObjects;
    //public PieChart visualizeObjects;

    // Start is called before the first frame update
    void Start()
    {
        VisualizerObjects = GetComponentsInChildren<VisualizerObjectScript>();

    }

    // Update is called once per frame
    void Update()
    {
        


        // newResults = script.results;
        //Debug.Log(PieChart);
        //Debug.Log("anger:" + newResults[3]);
    }
}