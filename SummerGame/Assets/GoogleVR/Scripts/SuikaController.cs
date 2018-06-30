using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuikaController : MonoBehaviour {

    private Rigidbody rb;
    public float direction;
    public float timeout;
    private float timeElapsed;
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
        timeElapsed += Time.deltaTime;
        if(timeElapsed >= timeout){
            Destroy(this.gameObject);
            timeElapsed = 0.0f;
        }
	}

    void Pakkan(){
        rb.constraints = RigidbodyConstraints.None;
        rb.AddForce(new Vector3(direction, 2, 0), ForceMode.Impulse);
        rb.AddTorque(0, 0, -direction);
    }

}
