using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScript : MonoBehaviour {

	// Use this for initialization
    public void Change () {
		SceneManager.LoadScene ("Main1");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
