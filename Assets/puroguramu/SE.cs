using UnityEngine;

public class SE : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // AudioSource�R���|�[�l���g���擾
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        // ���ʉ����Đ�
        audioSource.Play();
    }
}