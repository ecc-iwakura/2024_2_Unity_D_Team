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
            transform.Rotate(Vector3.forward, scrollDelta * 100f); // �p�x�̕ύX���x�𒲐����邽�߂�100f��ύX���邱�Ƃ��ł��܂�
        }
    }

    void OnMouseUp()
    {
        isDragging = false;
    }
}
