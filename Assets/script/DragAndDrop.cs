using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    void OnMouseDown()
    {
        // �X�v���C�g�̃����_���[��sortingLayerName��ݒ肵�āAStella���C���[��D�悳����
        GetComponent<SpriteRenderer>().sortingLayerName = "Stella";
        GetComponent<SpriteRenderer>().sortingOrder = 0; // �K�v�ɉ�����sortingOrder���ݒ�

        // �I�u�W�F�N�g�̈ʒu�ƃ}�E�X�ʒu�̍������v�Z����
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        isDragging = true;
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            // �}�E�X�ʒu�ƍ�������V�����ʒu���v�Z����
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)) + offset;
            transform.position = newPosition;

            // �}�E�X�̃X�N���[���z�C�[���̓��͂Ɋ�Â��ăI�u�W�F�N�g����]������
            float scrollDelta = Input.GetAxis("Mouse ScrollWheel");
            transform.Rotate(Vector3.forward, scrollDelta * 100f); // ��]���x�𒲐�����ꍇ�́A100f��ύX���Ă�������
        }
    }

    void OnMouseUp()
    {
        isDragging = false;
    }
}
