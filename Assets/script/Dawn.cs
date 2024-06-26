using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dawn : MonoBehaviour
{
    public float distance = 10f; // 移動する距離
    public float duration = 5f; // 移動にかかる時間

    private float startTime;
    private Vector3 startPos;
    private bool isMoving = true; // 移動中かどうかを示すフラグ

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
                isMoving = false; // 移動完了
            }
        }
    }
}
