using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSelected : MonoBehaviour {

    public static int nextSword = 0;

    private bool up;
    public GameObject sword;
    private Vector3 pos;
    private Vector3 pos2;

    public SwordSelected[] sss;
    public GameObject obstacle;

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
    public void Untouched(){
        up = false;
    }
    public void Selected(int next)
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        sword.SetActive(true);
        foreach(SwordSelected ss in sss)
        {
            ss.enabled = false;
        }
        obstacle.SetActive(true);
        nextSword = next;
        StartCoroutine(BlackOut());
    }

    public MeshRenderer sky;
    private IEnumerator BlackOut()
    {
        yield return new WaitForSeconds(1f);
        while (true)
        {
            Color tmp = sky.material.color;
            tmp.a += 0.2f * Time.deltaTime;
            Debug.Log(tmp.a);
            sky.material.color = tmp;
            if (sky.material.color.a >= 0.9f)
            {
                sky.material.color = Color.black;
                break;
            }
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        SceneLoading.LoadScene("Main2");
    }
}
