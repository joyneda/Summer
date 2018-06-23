using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuikaController : MonoBehaviour {

    private Rigidbody rb;
    public float direction;
	// Use this for initialization
	void Start () {
        rb = this.gameObject.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeAll;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space)){
            Pakkan();
        }
	}

    void Pakkan(){
        rb.constraints = RigidbodyConstraints.None;
        rb.AddForce(new Vector3(direction, 2, 0), ForceMode.Impulse);
        rb.AddTorque(0, 0, -direction);
    }
}
