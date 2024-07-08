using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    void OnMouseDown()
    {
        // スプライトのレンダラーのsortingLayerNameを設定して、Stellaレイヤーを優先させる
        GetComponent<SpriteRenderer>().sortingLayerName = "Stella";
        GetComponent<SpriteRenderer>().sortingOrder = 0; // 必要に応じてsortingOrderも設定

        // オブジェクトの位置とマウス位置の差分を計算する
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        isDragging = true;
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            // マウス位置と差分から新しい位置を計算する
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)) + offset;
            transform.position = newPosition;

            // マウスのスクロールホイールの入力に基づいてオブジェクトを回転させる
            float scrollDelta = Input.GetAxis("Mouse ScrollWheel");
            transform.Rotate(Vector3.forward, scrollDelta * 100f); // 回転速度を調整する場合は、100fを変更してください
        }
    }

    void OnMouseUp()
    {
        isDragging = false;
    }
}
