using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objects; // 表示/非表示にするオブジェクト
    [SerializeField]
    private Score score; // スコアを参照するためのスクリプト

    private void Start()
    {
        UpdateObjects();
    }

    private void Update()
    {
        UpdateObjects();
    }

    private void UpdateObjects()
    {
        int currentScore = score.GetScore();

        if (currentScore <= 12000)
        {
            // スコアが10000以下の場合、最初の3つのオブジェクトを表示し、残りを非表示にする
            for (int i = 0; i < objects.Length; i++)
            {
                if (i < 3)
                {
                    objects[i].SetActive(true);
                }
                else
                {
                    objects[i].SetActive(false);
                }
            }
        }
        else if (currentScore >= 12001)
        {
            // スコアが10001以上の場合、すべてのオブジェクトを表示する
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].SetActive(true);
            }
        }
    }
}
