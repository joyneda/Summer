using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashingController : MonoBehaviour {

    private GameObject mainCamera;
    private Rigidbody rb;
    public float timeOut;
    private float TimeElaps;
    public float speed;

	// Use this for initialization
	void Start () {
        mainCamera = Camera.main.gameObject;
         rb = this.gameObject.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(mainCamera.transform.forward*speed, ForceMode.Impulse);
        TimeElaps += Time.deltaTime;
        if(timeOut<TimeElaps){
            Destroy(this.gameObject);
        }
	}
}
