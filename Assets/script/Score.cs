using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    int score=0; // スコアの配列
    
    public GameObject[] scoreObjects = null; // Textオブジェクト
    
    
    void Start()
    {
        for (int i = 0; i < scoreObjects.Length; i++)
        {
            Text scoreText = scoreObjects[i].GetComponent<Text>();
            // 初期表示を設定するなどの処理があればここで行う
        }
    }

    void Update()
    {
        for (int i = 0; i < scoreObjects.Length; i++)
        {
            Text scoreText = scoreObjects[i].GetComponent<Text>();
        // テキストの表示を入れ替える
        scoreText.text = "Score:" + (score / 1);
        }
    }

    public void AddScore(int value)
    {


        score += value;
    }

    public int GetScore()
    {

        return score;
    }
}
