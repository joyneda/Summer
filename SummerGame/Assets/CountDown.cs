using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

    public Text text;
    public GameObject suika;
    public Timecontroller tc;

	// Use this for initialization
	void Start () {
        StartCoroutine(Count());
	}

    private IEnumerator Count()
    {
        text.text = "ゲーム開始まで\n" + 3;
        yield return new WaitForSeconds(1f);
        text.text = "ゲーム開始まで\n" + 2;
        yield return new WaitForSeconds(1f);
        text.text = "ゲーム開始まで\n" + 1;
        yield return new WaitForSeconds(1f);
        text.text = "スタート！";
        yield return new WaitForSeconds(1f);
        suika.SetActive(true);
        tc.enabled = true;
        Destroy(this.gameObject);
    }
}
