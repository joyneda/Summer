using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashController : MonoBehaviour {

    public GameObject Obj;
    private GameObject mainCamera;
    public GameObject ken;
    public bool lapse;
    public float coolTime;
    private float lapseTime;

	// Use this for initialization
	void Start () {
        mainCamera = Camera.main.gameObject;


        lapseTime = 0;

	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(GvrControllerInput.Accel);

        if (lapse == true)
        {
            if (Mag() > 12.0f)
            {
                Instantiate(Obj, ken.transform.position, Quaternion.identity);


                lapse = false;
            }
        }
        if(lapse == false){
            lapseTime += Time.deltaTime;
            if(lapseTime > coolTime){
                lapse = true;
                lapseTime = 0;
            }
        }
        }
	

    double Mag(){
        Vector3 accel = GvrControllerInput.Accel;
        return Mathf.Sqrt(accel.x*accel.x+accel.y*accel.y+accel.z*accel.z);
    }
}
