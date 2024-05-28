using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    void OnMouseDown()
    {
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        isDragging = true;
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)) + offset;
            transform.position = newPosition;

            float scrollDelta = Input.GetAxis("Mouse ScrollWheel");
            transform.Rotate(Vector3.forward, scrollDelta * 100f); // 角度の変更速度を調整するために100fを変更することができます
        }
    }

    void OnMouseUp()
    {
        isDragging = false;
    }
}
