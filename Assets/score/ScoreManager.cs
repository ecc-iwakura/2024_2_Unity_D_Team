using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;  // UIのTextオブジェクトを参照
    private int score;      // スコアの値を保存する変数

    void Start()
    {
        score = 0; // スコアの初期化
        UpdateScoreText();
    }

    // スコアを加算するメソッド
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // スコアテキストを更新するメソッド
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
