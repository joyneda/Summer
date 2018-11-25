using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour {

    public Text scoreText;
    public bool end = false;
    
	// Use this for initialization
	void Start () {
        scoreText.text = Counter.score.ToString();
        if (end) Destroy(this);
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = Counter.score.ToString();
	}
	
}
