using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuitekuruver2 : MonoBehaviour
{
    // �������g���K�[�G���A�ɓ������Ƃ��ɌĂ΂��
    private void OnTriggerEnter2D(Collider2D other)
    {
        // �g���K�[�ɓ������I�u�W�F�N�g���q�I�u�W�F�N�g�ɂ���
        other.transform.SetParent(transform);
    }

    // �������g���K�[�G���A����o���Ƃ��ɌĂ΂��
    private void OnTriggerExit2D(Collider2D other)
    {
        // �g���K�[����o���I�u�W�F�N�g�̐e�q�֌W����������
        if (other.transform.parent == transform)
        {
            other.transform.SetParent(null);
        }
    }
}
