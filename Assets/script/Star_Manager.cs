using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class Star_Manager : MonoBehaviour
{
    public GameObject[] scoreObjects = null; // Textオブジェクト
    private Star_bag manager;

    
    int[] scores;

    // 初期化
    void Start()
    {

        manager = GetComponent<Star_bag>();
        scores = new int[scoreObjects.Length];

        for (int i = 0; i < scoreObjects.Length; i++)
        {
            Text scoreText = scoreObjects[i].GetComponent<Text>();
            // 初期表示を設定するなどの処理があればここで行う
        }
    }

    // 更新
    void Update()
    {
        if (Input.GetMouseButton(1) || Input.GetMouseButton(0))
        {
            for (int j = 0; j < scoreObjects.Length; j++)
            {
                Text scoreText = scoreObjects[j].GetComponent<Text>();
                scores[j] = manager.GetScore(j);
                // テキストの表示を入れ替える
                scoreText.text = "" + (scores[j] / 2);
            }
        }
    }
}
