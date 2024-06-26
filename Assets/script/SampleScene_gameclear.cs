using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleScene_gameclear:MonoBehaviour
{
    // ゲームが始まる時間
    private float gameTime;

    // ゲームが終了するまでの時間（秒）
    public float gameDuration = 300f;

    void Start()
    {
        // ゲームが始まる時間を記録
        gameTime = Time.time;
    }

    void Update()
    {
        // 現在の時間が開始時間にゲーム終了時間を加えたものより大きければ
        // ゲームクリア画面に遷移
        if (Time.time >= gameTime + gameDuration)
        {
            SceneManager.LoadScene("gameclear");
        }
    }
}
