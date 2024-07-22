using UnityEngine;

public class tuitekuru : MonoBehaviour
{
    public GameObject targetObject; // �Ǐ]�Ώۂ̃I�u�W�F�N�g
    private Transform originalParent; // ���̐e�I�u�W�F�N�g��Transform

    void OnTriggerEnter2D(Collider2D other)
    {
        // �Փ˂����I�u�W�F�N�g���Ǐ]�Ώۂ̏ꍇ
        if (other.gameObject == targetObject)
        {
            // ���̐e�I�u�W�F�N�g��ۑ�
            originalParent = other.transform.parent;

            // ���̃I�u�W�F�N�g��targetObject�̎q�I�u�W�F�N�g�ɂ���
            other.transform.parent = this.transform;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // �Ǐ]�Ώۂ��̈悩�痣�ꂽ�ꍇ
        if (other.gameObject == targetObject)
        {
            // �e�I�u�W�F�N�g�����ɖ߂�
            other.transform.parent = originalParent;
        }
    }
}
