using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dawn : MonoBehaviour
{
    public float distance = 10f; // �ړ����鋗��
    public float duration = 5f; // �ړ��ɂ����鎞��

    private float startTime;
    private Vector3 startPos;
    private bool isMoving = true; // �ړ������ǂ����������t���O

    void Start()
    {
        startTime = Time.time;
        startPos = transform.position;
    }

    void Update()
    {
        if (isMoving)
        {
            float timePassed = Time.time - startTime;
            if (timePassed < duration)
            {
                float distanceMoved = (distance / duration) * timePassed;
                transform.position = startPos + Vector3.up * distanceMoved;
            }
            else
            {
                transform.position = startPos + Vector3.up * distance;
                isMoving = false; // �ړ�����
            }
        }
    }
}
