using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashController : MonoBehaviour {

    public GameObject Obj;
    private GameObject mainCamera;

	// Use this for initialization
	void Start () {
        mainCamera = Camera.main.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(GvrControllerInput.Accel);
        if(Mag()>3.0f){
            Instantiate(Obj, mainCamera.transform.position, Quaternion.identity);
        }
            
        }
	

    double Mag(){
        Vector3 accel = GvrControllerInput.Accel;
        return 0.0f;
    }
}
