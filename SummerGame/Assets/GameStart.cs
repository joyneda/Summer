using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour {

    public GameObject sword;
    public MeshRenderer sky;
    public bool start = false;

    void Start()
    {
        sky.material.color = Color.clear;
    }

    void Update()
    {
        if (!start)
        {
            if (GvrControllerInput.ClickButton)
            {
                StartGame();
                start = true;
            }
        }
    }

	public void StartGame()
    {
        sword.SetActive(true);
        Destroy(this.GetComponent<Collider>());
        StartCoroutine(Load());
    }

    private IEnumerator Load()
    {
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

        SceneLoading.LoadScene("Main1");
    }
}
