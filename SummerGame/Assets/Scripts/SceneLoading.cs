using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour {

    public static string loadSceneName;
    private AsyncOperation load;

    private float minimamWaitTime = 5f;
    private float time;

    public MeshRenderer sky;
    private bool allowSceneActivation = false;

    void Awake()
    {
        sky.material.color = Color.black;
        StartCoroutine(Loaded());
    }

	// Use this for initialization
	void Start () {
        load = SceneManager.LoadSceneAsync(loadSceneName);
        load.allowSceneActivation = false;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        Debug.Log(time);

        if (time >= minimamWaitTime)
        {
            if (load.progress >= 0.9f) StartCoroutine(Load());
        }
	}

    private IEnumerator Loaded()
    {
        while (true)
        {
            Color tmp = sky.material.color;
            tmp.a -= 2f * Time.deltaTime;
            sky.material.color = tmp;
            if (sky.material.color.a <= 0.1f)
            {
                sky.material.color = Color.clear;
                break;
            }
            yield return null;
        }
    }
    private IEnumerator Load()
    {
        while (true)
        {
            Color tmp = sky.material.color;
            tmp.a += 0.05f * Time.deltaTime;
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
        load.allowSceneActivation = true;
    }
    public static void LoadScene(string loadScene)
    {
        loadSceneName = loadScene;
        SceneManager.LoadScene("Loading");
    }
}
