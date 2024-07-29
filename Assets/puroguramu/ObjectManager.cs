using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objects; // �\��/��\���ɂ���I�u�W�F�N�g
    [SerializeField]
    private Score score; // �X�R�A���Q�Ƃ��邽�߂̃X�N���v�g

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
            // �X�R�A��10000�ȉ��̏ꍇ�A�ŏ���3�̃I�u�W�F�N�g��\�����A�c����\���ɂ���
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
            // �X�R�A��10001�ȏ�̏ꍇ�A���ׂẴI�u�W�F�N�g��\������
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].SetActive(true);
            }
        }
    }
}
