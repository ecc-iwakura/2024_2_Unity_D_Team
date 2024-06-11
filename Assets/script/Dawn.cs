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
            float t = (Time.time - startTime) / duration;
            Vector3 newPosition = startPos + Vector3.up * (distance / duration) * t;
            transform.position = newPosition;

          
        }
    }
}
