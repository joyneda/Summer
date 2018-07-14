using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AimController : MonoBehaviour {

	private UnityEngine.UI.Image aim;
	private GameObject mainCamera;

	// Use this for initialization
	void Start () {
		aim = this.GetComponent<UnityEngine.UI.Image>();
		mainCamera = Camera.main.gameObject;//MainCameraを取得する
	}

	// Update is called once per frame
	void Update () {
		Ray ray = new Ray (mainCamera.transform.position, mainCamera.transform.forward);
		//Debug.DrawRay(ray.origin,ray.direction,Color.red);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 15f)) {
			//Debug.DrawLine(ray.origin, hit.point, Color.red);

			Target target = hit.collider.gameObject.GetComponent<Target> ();
			if (target) {
				SceneManager.LoadScene ("Main1");
			}
		}
	}
}