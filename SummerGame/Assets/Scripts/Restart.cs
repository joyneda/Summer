using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public void RestartButton()
    {
        Counter.score = 0;
        SwordSelected.nextSword = 0;
        SceneManager.LoadScene("Start");
    }
}
