using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sky : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        MeshRenderer mr = this.GetComponent<MeshRenderer>();
        Color c = mr.material.color;
        c.a = 0;
        mr.material.color = c;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
