using UnityEngine;

public class SE : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // AudioSourceコンポーネントを取得
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        // 効果音を再生
        audioSource.Play();
    }
}