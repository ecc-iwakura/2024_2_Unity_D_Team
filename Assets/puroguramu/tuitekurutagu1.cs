using UnityEngine;

public class tuitekurutagu1 : MonoBehaviour
{
    public string followTag = "FollowTag"; // �Ǐ]�Ώۂ̃^�O
    private Transform originalParent; // ���̐e�I�u�W�F�N�g��Transform

    void OnTriggerEnter2D(Collider2D other)
    {
        // �Փ˂����I�u�W�F�N�g���w��̃^�O�������Ă���ꍇ
        if (other.gameObject.CompareTag(followTag))
        {
            // ���̐e�I�u�W�F�N�g��ۑ�
            originalParent = other.transform.parent;

            // ���̃I�u�W�F�N�g���Փ˂����I�u�W�F�N�g�̎q�I�u�W�F�N�g�ɂ���
            other.transform.parent = this.transform;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // �w��̃^�O�����I�u�W�F�N�g���̈悩�痣�ꂽ�ꍇ
        if (other.gameObject.CompareTag(followTag))
        {
            // �e�I�u�W�F�N�g�����ɖ߂�
            other.transform.parent = originalParent;
        }
    }
}

