using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // 切り替えるシーンの名前を指定します
    public int Sample;

    void Update()
    {
        // 左クリックを検知
        if (Input.GetMouseButtonDown(0))
        {
            // 指定されたシーンに切り替える
            SceneManager.LoadScene(Sample);
        }
    }
}