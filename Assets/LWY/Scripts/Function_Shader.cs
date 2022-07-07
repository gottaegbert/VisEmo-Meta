using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function_Shader : MonoBehaviour
{
    public GameObject Ch03;
    public Material dissolveMat;
    public float health;
    public float maxHealth;
    
    void Start()
    {
        //dissolveMat.SetFloat("Vector1_0442e26947fd4acb843e1a6f0751292a", health / maxHealth);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("@##$#$");
            health -= 5;
            
            //Change Dissolve value
            //dissolveMat.SetFloat("Vector1_0442e26947fd4acb843e1a6f0751292a", health / maxHealth);
            
            //Change Color property
            dissolveMat.SetColor("_Color", Color.red);


            //Ch03.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
            //Debug.Log(material.name);

            //material.SetColor("_Color",Color.blue);

            //material.color=Color.blue;
            //material.SetVector("_EdgeColor",new Vector4(1,1,1,1));
            //material.SetFloat("_Dissolve",0.9f);

            //GetComponent<Renderer>().material = material;

        }
       
    }
}
