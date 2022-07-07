using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Function_DoubletoFloat : MonoBehaviour
{

    //Set emoj parameters to 0-100, double[] to float[]

    public static float emoMath(double x)
    {
        return (float)Math.Round(x * 100, 2);
    }

   
}
