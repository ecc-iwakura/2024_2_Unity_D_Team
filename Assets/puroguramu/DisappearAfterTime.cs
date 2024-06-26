using UnityEngine;

public class DisappearAfterTime : MonoBehaviour
{
    public float disappearTime = 5f; // 消えるまでの時間（秒）

    void Start()
    {
        // disappearTime秒後にDestroy関数を呼び出す
        Destroy(gameObject, disappearTime);
    }
}