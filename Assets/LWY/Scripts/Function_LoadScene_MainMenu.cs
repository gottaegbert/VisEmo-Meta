using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Function_LoadScene_MainMenu : MonoBehaviour
{
   public void PlayScene1(){
        SceneManager.LoadScene("2.Meeting");
   }

    public void PlayScene2()
    {
        SceneManager.LoadScene("3.Party");
    }

    public void PlayScene2Girl()
    {
        SceneManager.LoadScene("datescene-girl");
    }

    public void ExitGame(){
        SceneManager.LoadScene("1.Menu");
   }


    



}
