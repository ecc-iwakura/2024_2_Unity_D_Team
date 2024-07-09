using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;  // UI��Text�I�u�W�F�N�g���Q��
    private int score;      // �X�R�A�̒l��ۑ�����ϐ�

    void Start()
    {
        score = 0; // �X�R�A�̏�����
        UpdateScoreText();
    }

    // �X�R�A�����Z���郁�\�b�h
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // �X�R�A�e�L�X�g���X�V���郁�\�b�h
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
