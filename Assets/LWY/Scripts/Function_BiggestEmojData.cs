using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function_BiggestEmojData : MonoBehaviour
{

    public static (float,int) GetMax (double[]array){

        double max=array[2];
        float biggestData;

        int sequence=2;
        for(int i=3;i<7;i++){
            if(max<array[i]){

                max= array[i];

                sequence=i;
            }
        }

        biggestData=Function_DoubletoFloat.emoMath(max);

        return(biggestData,sequence);

    }
}
