using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // �؂�ւ���V�[���̖��O���w�肵�܂�
    public int Sample;

    void Update()
    {
        // ���N���b�N�����m
        if (Input.GetMouseButtonDown(0))
        {
            // �w�肳�ꂽ�V�[���ɐ؂�ւ���
            SceneManager.LoadScene(Sample);
        }
    }
}