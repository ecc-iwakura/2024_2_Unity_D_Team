using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class Star_Manager : MonoBehaviour
{
    public GameObject[] scoreObjects = null; // Text�I�u�W�F�N�g
    private Star_bag manager;

    
    int[] scores;

    // ������
    void Start()
    {

        manager = GetComponent<Star_bag>();
        scores = new int[scoreObjects.Length];

        for (int i = 0; i < scoreObjects.Length; i++)
        {
            Text scoreText = scoreObjects[i].GetComponent<Text>();
            // �����\����ݒ肷��Ȃǂ̏���������΂����ōs��
        }
    }

    // �X�V
    void Update()
    {
        if (Input.GetMouseButton(1) || Input.GetMouseButton(0))
        {
            for (int j = 0; j < scoreObjects.Length; j++)
            {
                Text scoreText = scoreObjects[j].GetComponent<Text>();
                scores[j] = manager.GetScore(j);
                // �e�L�X�g�̕\�������ւ���
                scoreText.text = "" + (scores[j] / 2);
            }
        }
    }
}
