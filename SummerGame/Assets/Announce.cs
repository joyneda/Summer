using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Announce : MonoBehaviour {

    public Text text;

	// Use this for initialization
	void Start () {
        StartCoroutine(Tenmetu());
	}

    private IEnumerator Tenmetu()
    {
        while(true){
            text.enabled = true;
            yield return new WaitForSeconds(0.7f);
            text.enabled = false;
            yield return new WaitForSeconds(0.7f);
        }
    }
}
