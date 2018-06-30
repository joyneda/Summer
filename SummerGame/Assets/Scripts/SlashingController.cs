using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashingController : MonoBehaviour {

    private GameObject mainCamera;

	// Use this for initialization
	void Start () {
        mainCamera = Camera.main.gameObject;
        Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(mainCamera.transform.forward,ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
