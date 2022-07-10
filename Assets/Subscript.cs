using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Subscript : MonoBehaviour
{

    public GameObject textBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    IEnumerator TheSequence()
    {
        
        textBox.GetComponent<TMP_Text>().SetText("In the “Social” scene, you can discover more interesting emotions when socializing with others. ");
        yield return new WaitForSeconds(5);
        textBox.GetComponent<TMP_Text>().SetText("When you are happy, your avatar would pop up with the corresponding emoji. And you would trigger" +
            "a happy animation and your clothes would change. Even the environment like the upper sky’s aurora would adjust based on the whole party’s emotional status.");
    }
}
