using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Move : MonoBehaviour
{
    public float fallSpeed = 5f; // �������x
    public Vector2 direction = new Vector2(1, -1); // �΂ߕ����̃x�N�g��

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0; // �d�͂𖳌��ɂ���
        Destroy(this.gameObject,4);
    }

    void Update()
    {
        // ���K�����������x�N�g���ɑ��x���|���ė͂�������
        rb.velocity = direction.normalized * fallSpeed;
    }
}