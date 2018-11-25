using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timecontroller : MonoBehaviour {

    public Text timerText;
    public float totalTime;
    int seconds;
    public string nextSceneName;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (totalTime <= 0)
        {
            timeUp = true;
        }
        if(totalTime <= -5)
        {
            SceneLoading.LoadScene(nextSceneName);
        }

        totalTime -= Time.deltaTime;
        if (!timeUp)
        {
            seconds = (int)totalTime;
            timerText.text = seconds.ToString();
        }
	}

    private bool timeUp = false;
    public bool TimeUp()
    {
        return timeUp;
    }
}
