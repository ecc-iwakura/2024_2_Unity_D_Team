using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    int score=0; // �X�R�A�̔z��
    public GameObject scoreObjects = null; // Text�I�u�W�F�N�g
    
    
    void Start()
    {

            Text scoreText = scoreObjects.GetComponent<Text>();
            // �����\����ݒ肷��Ȃǂ̏���������΂����ōs��
        
    }

    void Update()
    {
        Text scoreText = scoreObjects.GetComponent<Text>();
        // �e�L�X�g�̕\�������ւ���
        scoreText.text = "Score:" + (score / 1);
    }

    public void AddScore(int value)
    {


        score += value;
    }

    public int GetScore(int index)
    {

        return score;
    }
}
