using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Move : MonoBehaviour
{
    public float fallSpeed = 5f; // 落下速度
    public Vector2 direction = new Vector2(1, -1); // 斜め方向のベクトル

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0; // 重力を無効にする
        Destroy(this.gameObject,4);
    }

    void Update()
    {
        // 正規化した方向ベクトルに速度を掛けて力を加える
        rb.velocity = direction.normalized * fallSpeed;
    }
}
