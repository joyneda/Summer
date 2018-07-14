using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSelected : MonoBehaviour {

    private bool up;
    public GameObject sword;
    private Vector3 pos;
    private Vector3 pos2;

	// Use this for initialization
	void Start () {
        pos = this.transform.position;
        pos2 = pos + Vector3.up;
	}
	
	// Update is called once per frame
	void Update () {
        if(up){
            if(this.transform.position.y <= pos2.y){
                this.transform.position += Vector3.up * Time.deltaTime;
            }
        }
        else{
            if (this.transform.position.y >= pos.y)
            {
                this.transform.position -= Vector3.up * Time.deltaTime;
            }
        }
	}

    public void Touched(){
        up = true;
    }
    public void Selected(){
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        sword.SetActive(true);
    }
    public void Untouched(){
        up = false;
    }
    public void Unselected(){
        this.gameObject.GetComponent<MeshRenderer>().enabled = true;
        sword.SetActive(false);
    }
}
