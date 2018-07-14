using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashController : MonoBehaviour {

    public GameObject Obj;
    private GameObject mainCamera;
    public GameObject ken;

	// Use this for initialization
	void Start () {
        mainCamera = Camera.main.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(GvrControllerInput.Accel);
        if(Mag()>12.0f){
            Instantiate(Obj, ken.transform.position, Quaternion.identity);
        }
            
        }
	

    double Mag(){
        Vector3 accel = GvrControllerInput.Accel;
        return Mathf.Sqrt(accel.x*accel.x+accel.y*accel.y+accel.z*accel.z);
    }
}
