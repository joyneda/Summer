using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text scoreText; //Text用変数
   public static int score; //スコア計算用変数
    public bool Hitbool = true;

  void Start()
    {
        score = 0;

        SetScore();   //初期スコアを代入して表示
    }

	 

	//cube同士での衝突＋100 cube以外との衝突＋100
	void OnCollisionEnter(Collision collision)
    {
        if (Hitbool)
        {
            if (collision.gameObject.CompareTag("watermelon"))
            {
                Debug.Log("atat");
                score = score + 10;
                SetScore();
            }
        }
    }
    void SetScore()
    {
        scoreText.text = " " + score.ToString();
    }


}
