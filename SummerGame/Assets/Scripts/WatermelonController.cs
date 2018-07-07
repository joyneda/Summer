using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WatermelonController : MonoBehaviour
{
    public Vector3 spawnValue;
    public float startwait;
    public float spawnWait;
    public GameObject suika;
    public Text scoreText;
    public int score ;
    // Use this for initialization
    void Start()
    {
        StartCoroutine("SpawnWave");
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnWave()
    {
        yield return new WaitForSeconds(startwait);
        while (true)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(-spawnValue.x, spawnValue.x),
                spawnValue.y,
                Random.Range(-spawnValue.z, spawnValue.z)
            );
            Instantiate(suika, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnWait);
        }
    }
    public void AddScore(int newSceneValue){
        score += newSceneValue;
        UpdateScore();
    }
	

	void UpdateScore(){
        scoreText.text = " " + score;
    }
}