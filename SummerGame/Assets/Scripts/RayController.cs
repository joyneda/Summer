using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController : MonoBehaviour {

    private UnityEngine.UI.Image aim;
    private GameObject Pointer;
	// Use this for initialization
	void Start () {
        aim = this.GetComponent<UnityEngine.UI.Image>();
        Pointer = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = new Ray(Pointer.transform.position, Pointer.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction, Color.red);
	}
}
