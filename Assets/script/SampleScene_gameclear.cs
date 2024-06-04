using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleScene_gameclear:MonoBehaviour
{
    // �Q�[�����n�܂鎞��
    private float gameTime;

    // �Q�[�����I������܂ł̎��ԁi�b�j
    public float gameDuration = 300f;

    void Start()
    {
        // �Q�[�����n�܂鎞�Ԃ��L�^
        gameTime = Time.time;
    }

    void Update()
    {
        // ���݂̎��Ԃ��J�n���ԂɃQ�[���I�����Ԃ����������̂��傫�����
        // �Q�[���N���A��ʂɑJ��
        if (Time.time >= gameTime + gameDuration)
        {
            SceneManager.LoadScene("gameclear");
        }
    }
}
