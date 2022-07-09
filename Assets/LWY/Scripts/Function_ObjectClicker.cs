using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class Function_ObjectClicker : MonoBehaviour
{
    private Camera _mainCamera;
    public GameObject CameraTarget;
    public GameObject PlayerFllowCamera;
    private CinemachineVirtualCamera cinemachine;

    //Set Player
    public GameObject Player;

    private Ray _ray;
    private RaycastHit _hit;
    bool status = false;

    
    private void Start() {
        _mainCamera = Camera.main;
    }


    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _ray = _mainCamera.ScreenPointToRay(Input.mousePosition);


            if (Physics.Raycast(_ray, out _hit,1000f))
            {
                //Select stage    
                if (_hit.transform == transform)
                    {
                    if (status==false)
                    {
                        SitDown();
                        status=true;
                    }
                    else
                    {
                        StandUp();
                        status = false;
                    }

                }
            }
        }
    }

    void SitDown()
    {
        Debug.Log("Sitdown");

        //Reverse SitdownObject
        transform.Rotate(180, 0, 0);

        //Set Camera
        //cinemachine.

        //CameraTarget.transform.localPosition=new Vector3(0, 1.5f, 3.0f);
        //Player.SetActive(false);


        //Set Functions
        Player.GetComponent<CharacterController>().enabled = false;

        //Make legs & feet invisible
        Player.transform.GetChild(7).gameObject.SetActive(false);
        Player.transform.GetChild(8).gameObject.SetActive(false);



    }

    void StandUp()
    {
        Debug.Log("StandUp");

        //Reverse SitdownObject
        transform.Rotate(180, 0, 0);

        //Set Camera
        //CameraTarget.transform.localPosition = new Vector3(0, 1.5f, 0f);


        //Set Functionsaass
        Player.transform.position = new Vector3(5.2f, 0f, 1.73f);
        Player.GetComponent<CharacterController>().enabled = true;

        //Make legs & feet invisible
        Player.transform.GetChild(7).gameObject.SetActive(true);
        Player.transform.GetChild(8).gameObject.SetActive(true);
    }


}
