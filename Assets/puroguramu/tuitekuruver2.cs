using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuitekuruver2 : MonoBehaviour
{
    // 何かがトリガーエリアに入ったときに呼ばれる
    private void OnTriggerEnter2D(Collider2D other)
    {
        // トリガーに入ったオブジェクトを子オブジェクトにする
        other.transform.SetParent(transform);
    }

    // 何かがトリガーエリアから出たときに呼ばれる
    private void OnTriggerExit2D(Collider2D other)
    {
        // トリガーから出たオブジェクトの親子関係を解除する
        if (other.transform.parent == transform)
        {
            other.transform.SetParent(null);
        }
    }
}
